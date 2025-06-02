using System.Text.Json.Serialization;

namespace Corner49.PayNL.V3.Requests.Orders.InputMethods;

public class Przelewy27Input : V3InputMethod {
	[JsonPropertyName("email")]
	public string Email { get; set; }
}
