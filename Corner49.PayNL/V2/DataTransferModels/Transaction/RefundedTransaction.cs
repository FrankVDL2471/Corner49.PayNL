using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Transaction;

public class RefundedTransaction {
	[JsonPropertyName("amountRefunded")]
	public Amount? AmountRefunded { get; set; }

	[JsonPropertyName("refund")]
	public Refund? Refund { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTime CreatedAt { get; set; }

	[JsonPropertyName("createdBy")]
	public string? CreatedBy { get; set; }
}