using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Transaction;

public class PaymentBankAccount {
	[JsonPropertyName("iban")]
	public string? Iban { get; set; }

	[JsonPropertyName("bic")]
	public string? Bic { get; set; }

	[JsonPropertyName("owner")]
	public string? Owner { get; set; }
}