using System.Text.Json.Serialization;

namespace Corner49.PayNL.V3.Requests.Orders;

public class ProductToCapture {
	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("quantity")]
	public int Quantity { get; set; }
}
