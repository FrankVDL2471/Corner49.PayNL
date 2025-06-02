using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.ClearingAccounts;

public class CreateClearingAccountRequest {
	[JsonPropertyName("merchantCode")]
	public string? MerchantCode { get; set; }

	[JsonPropertyName("clearingAccount")]
	public ClearingAccountRequest? ClearingAccount { get; set; }
}
