using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants.Clearings;

public class ClearingLineType {
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("name")]
	public string? Name { get; set; }
}
