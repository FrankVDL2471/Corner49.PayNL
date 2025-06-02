using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.TerminalPayments;

public class PinTransactionCancelResponse {
	[JsonPropertyName("error")]
	public string? Error { get; set; }

	[JsonPropertyName("errormsg")]
	public string? ErrorMessage { get; set; }
}