using System.Net;
using System.Text.Json;
using Corner49.PayNL.V2.DataTransferModels;

namespace Corner49.PayNL.Utilities;

internal static class ExceptionHandlingExtension {
	internal static async Task HandleException(this HttpResponseMessage response) {
		if (response.IsSuccessStatusCode) {
			return;
		}

		switch ((int)response.StatusCode) {
			case (int)HttpStatusCode.Unauthorized when response.Content != null:
			case (int)HttpStatusCode.NotFound when response.Content != null:
			case (int)HttpStatusCode.MethodNotAllowed when response.Content != null:
			case (int)HttpStatusCode.BadRequest when response.Content != null:
			case 422 when response.Content != null:
				try {
					var content = await response.Content.ReadAsStringAsync();
					var error = JsonSerializer.Deserialize<ApiError>(content);
					if (error != null) {
						throw new PayNlException(error);
					}
					var body = string.IsNullOrWhiteSpace(content) ? string.Empty : $", Response body: {content}";
					throw new PayNlException($"Unknown error for {response.StatusCode} when calling {response.RequestMessage.RequestUri.AbsoluteUri}{body}");
				} catch (JsonException ex1) {
					var content = await response.Content.ReadAsStringAsync();
					throw new PayNlException($"Unknown error for {response.StatusCode}, Response body: {content}", ex1);
				}
			case (int)HttpStatusCode.InternalServerError:
			case (int)HttpStatusCode.NotImplemented:
			case (int)HttpStatusCode.BadGateway:
			case (int)HttpStatusCode.ServiceUnavailable:
			case (int)HttpStatusCode.GatewayTimeout:
			case (int)HttpStatusCode.HttpVersionNotSupported:
				throw new PayNlException("Something went wrong on our end, please try again");
			default:
				throw new PayNlException($"Unhandled status code {response.StatusCode}, body: {(response.Content != null ? await response.Content.ReadAsStringAsync() : "No content provided")}");
		}
	}
}
