using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants.InvoiceLines;

public class Cost {
	[JsonPropertyName("revenue")]
	public double? Revenue { get; set; }

	[JsonPropertyName("currency")]
	public string? Currency { get; set; }
}
