using System.Text.Json.Serialization;
using Corner49.PayNL.V2.Idin.Responses.Authentication;

namespace Corner49.PayNL.V2.Idin.Responses;

public class IdinAuthenticationStatusResponse {
	[JsonPropertyName("request")]
	public Request? Request { get; set; }

	[JsonPropertyName("data")]
	public IdinAuthenticationData? Data { get; set; }
}