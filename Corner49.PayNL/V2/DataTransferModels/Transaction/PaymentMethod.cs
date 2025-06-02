using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Transaction;

public class PaymentMethod {
	[JsonPropertyName("id")]
	public int? Id { get; set; }

	[JsonPropertyName("subId")]
	public int? SubId { get; set; }

	[JsonPropertyName("name")]
	public string? Name { get; set; }
}