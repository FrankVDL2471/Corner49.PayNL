using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Transaction;

public class Price {
	[JsonPropertyName("value")]
	public int? Value { get; set; }

	[JsonPropertyName("quantity")]
	public decimal? Quantity { get; set; }

	[JsonPropertyName("vatCode")]
	public string? VatCode { get; set; }
}