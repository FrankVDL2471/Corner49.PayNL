using HttpMultipartParser;
using System.Text.Json.Serialization;

namespace Corner49.PayNL.Utilities {
	public class WebHook {

		[JsonPropertyName("action")]
		public string? Action { get; set; }

		[JsonPropertyName("amount")]
		public decimal? Amount { get; set; }

		[JsonPropertyName("payment_method_id")]
		public int? PaymentMethodId { get; set; }


		[JsonIgnore]
		public string? PaymentMethod { get; set; }


		[JsonPropertyName("order_id")]
		public string? OrderId { get; set; }

		



		public static async Task<WebHook?> Parse(Stream data, bool isJson = true) {
			WebHook? hook = null;

			if (isJson) {
				string body;
				using (StreamReader reader = new StreamReader(data)) {
					body = await reader.ReadToEndAsync();
				}

				hook = System.Text.Json.JsonSerializer.Deserialize<WebHook>(body, new System.Text.Json.JsonSerializerOptions {
					NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString
				});
			} else {
				var parser = await MultipartFormDataParser.ParseAsync(data);
				hook = new WebHook();
				hook.Amount = decimal.Parse(parser.GetParameterValue("amount", StringComparison.OrdinalIgnoreCase).Replace(".", "").Replace(",", "")) / 1000.00m;
				hook.PaymentMethodId = int.Parse(parser.GetParameterValue("payment_method_id", StringComparison.OrdinalIgnoreCase));
				hook.OrderId= parser.GetParameterValue("order_id", StringComparison.OrdinalIgnoreCase);
				hook.Action= parser.GetParameterValue("action", StringComparison.OrdinalIgnoreCase);
			}

			if (hook?.PaymentMethodId != null) {
				hook.PaymentMethod = PaymentMethods.GetPaymentMethodName(hook.PaymentMethodId.Value);
			}

			return hook;
		}
		
	}
}
