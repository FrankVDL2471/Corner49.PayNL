using System.Text.Json.Serialization;
using Corner49.PayNL.V2.DataTransferModels.Transaction;

namespace Corner49.PayNL.V2.DataTransferModels.Vouchers;

public class Transaction {
	[JsonPropertyName("type")]
	public string? Type { get; set; }

	[JsonPropertyName("amount")]
	public Amount? Amount { get; set; }

	[JsonPropertyName("serviceId")]
	public string? ServiceId { get; set; }

	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("reference")]
	public string? Reference { get; set; }

	[JsonPropertyName("exchangeUrl")]
	public string? ExchangeUrl { get; set; }
}