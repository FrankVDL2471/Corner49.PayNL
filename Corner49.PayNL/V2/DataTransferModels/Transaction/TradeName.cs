using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Transaction;

public class TradeName {
	[JsonPropertyName("code")]
	public string? Code { get; set; }

	[JsonPropertyName("name")]
	public string? Name { get; set; }
}