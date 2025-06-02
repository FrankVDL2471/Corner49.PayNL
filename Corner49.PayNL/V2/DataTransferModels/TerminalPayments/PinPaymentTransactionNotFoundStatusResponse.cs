using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.TerminalPayments;

public class PinPaymentTransactionNotFoundStatusResponse : PinPaymentStatusResponse {
	[JsonPropertyName("errormsg")]
	public string? ErrorMessage { get; set; }

	[JsonPropertyName("error")]
	public string? Error { get; set; }
}