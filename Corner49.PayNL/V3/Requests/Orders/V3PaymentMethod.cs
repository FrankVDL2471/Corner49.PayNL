using System.Text.Json.Serialization;
using Corner49.PayNL.V3.Requests.Orders.InputMethods;

namespace Corner49.PayNL.V3.Requests.Orders;

public class V3PaymentMethod {
	[JsonPropertyName("input")]
	public V3InputMethod? Input { get; set; }

	[JsonPropertyName("id")]
	public int? Id { get; set; }

	[JsonPropertyName("optimize")]
	public List<string>? Optimize { get; set; }
}
