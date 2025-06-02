using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants.InvoiceLines;

public class Line {
	[JsonPropertyName("code")]
	public string? Code { get; set; }

	[JsonPropertyName("type")]
	public string? Type { get; set; }

	[JsonPropertyName("unitType")]
	public UnitType? UnitType { get; set; }

	[JsonPropertyName("amount")]
	public double? Amount { get; set; }

	[JsonPropertyName("costs")]
	public Cost? Costs { get; set; }

	[JsonPropertyName("processedDate")]
	public DateTime? ProcessedDate { get; set; }
}
