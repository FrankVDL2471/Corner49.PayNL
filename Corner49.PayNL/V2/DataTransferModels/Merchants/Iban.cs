using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants;

public class Iban {
	[JsonPropertyName("iban")]
	public string? IbanNumber { get; set; }

	[JsonPropertyName("bic")]
	public string? Bic { get; set; }

	[JsonPropertyName("owner")]
	public string? Owner { get; set; }
}