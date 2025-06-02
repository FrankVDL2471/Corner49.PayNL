using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.DirectDebit;

public class Interval {
	[JsonPropertyName("period")]
	public string? Period { get; set; }

	[JsonPropertyName("quantity")]
	public int? Quantity { get; set; }

	[JsonPropertyName("value")]
	public int? Value { get; set; }
}