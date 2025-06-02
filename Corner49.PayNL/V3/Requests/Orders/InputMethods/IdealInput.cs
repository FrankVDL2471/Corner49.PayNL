using System.Text.Json.Serialization;

namespace Corner49.PayNL.V3.Requests.Orders.InputMethods;

public class IdealInput : V3InputMethod {
	[JsonPropertyName("issuerId")]
	public string IssuerId { get; set; }
}
