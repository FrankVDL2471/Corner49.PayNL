using System.Text.Json.Serialization;
using Corner49.PayNL.V2.DataTransferModels.Transaction;

namespace Corner49.PayNL.V2.DataTransferModels.DirectDebit;

public class CreateDirectDebitOrderRequest {
	[JsonPropertyName("serviceId")]
	public string? ServiceId { get; set; }

	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("processDate")]
	public DateTime? ProcessDate { get; set; }

	[JsonPropertyName("customer")]
	public Customer? Customer { get; set; }

	[JsonPropertyName("amount")]
	public Amount? Amount { get; set; }

	[JsonPropertyName("interval")]
	public Interval? Interval { get; set; }

	[JsonPropertyName("stats")]
	public Stats? Stats { get; set; }

	[JsonPropertyName("exchangeUrl")]
	public string? ExchangeUrl { get; set; }
}
