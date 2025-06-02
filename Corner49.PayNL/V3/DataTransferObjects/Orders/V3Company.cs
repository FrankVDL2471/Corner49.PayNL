using System.Text.Json.Serialization;

namespace Corner49.PayNL.V3.DataTransferObjects.Orders;

public class V3Company {
	[JsonPropertyName("name")]
	public string? Name { get; set; }

	[JsonPropertyName("cocNumber")]
	public string? CocNumber { get; set; }

	[JsonPropertyName("vatNumber")]
	public string? VatNumber { get; set; }

	[JsonPropertyName("country")]
	public string? Country { get; set; }
}
