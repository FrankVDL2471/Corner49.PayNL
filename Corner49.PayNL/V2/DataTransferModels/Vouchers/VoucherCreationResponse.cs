using System.Text.Json.Serialization;
using Corner49.PayNL.V2.DataTransferModels.Transaction;

namespace Corner49.PayNL.V2.DataTransferModels.Vouchers;

public class VoucherCreationResponse {
	[JsonPropertyName("id")]
	public string? Id { get; set; }

	[JsonPropertyName("serviceId")]
	public string? ServiceId { get; set; }

	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("reference")]
	public string? Reference { get; set; }

	[JsonPropertyName("orderId")]
	public string? OrderId { get; set; }

	[JsonPropertyName("ipAddress")]
	public string? IpAddress { get; set; }

	[JsonPropertyName("amount")]
	public Amount? Amount { get; set; }

	[JsonPropertyName("created")]
	public DateTime? Created { get; set; }

	[JsonPropertyName("modified")]
	public DateTime? Modified { get; set; }
}