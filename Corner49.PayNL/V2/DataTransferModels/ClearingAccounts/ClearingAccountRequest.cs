using System.Text.Json.Serialization;
using Corner49.PayNL.V2.DataTransferModels.Merchants;

namespace Corner49.PayNL.V2.DataTransferModels.ClearingAccounts;

public class ClearingAccountRequest {
	[JsonPropertyName("method")]
	public string? Method { get; set; }

	[JsonPropertyName("iban")]
	public Iban? Iban { get; set; }

	[JsonPropertyName("documents")]
	public ClearingDocuments? Documents { get; set; }
}
