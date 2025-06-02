using System.Text.Json.Serialization;
using Corner49.PayNL.V2.DataTransferModels.Transaction;

namespace Corner49.PayNL.V2.DataTransferModels.DirectDebit;

public class CreateDirectDebitRequest {
	[JsonPropertyName("isLastOrder")]
	public bool? IsLastOrder { get; set; }

	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("processDate")]
	public string? ProcessDate { get; set; }

	[JsonPropertyName("amount")]
	public Amount? Amount { get; set; }

	[JsonPropertyName("stats")]
	public Stats? Stats { get; set; }
}
