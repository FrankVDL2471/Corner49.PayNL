using System.Text.Json.Serialization;

namespace Corner49.PayNL.V3.Requests.Orders.InputMethods;

public class KlarnaInput : V3InputMethod {
	[JsonPropertyName("countryCode")]
	public string CountryCode { get; set; }
}
