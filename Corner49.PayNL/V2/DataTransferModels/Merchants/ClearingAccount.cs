using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants;

public class ClearingAccount {
	[JsonPropertyName("method")]
	public string? Method { get; set; }

	[JsonPropertyName("iban")]
	public Iban? Iban { get; set; }
}