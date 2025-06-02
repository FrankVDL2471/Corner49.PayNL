using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.TerminalPayments;

public abstract class PinPaymentStatusResponse {
	[JsonPropertyName("status")]
	public string? Status { get; set; }

	[JsonPropertyName("terminal")]
	public string? Terminal { get; set; }
}