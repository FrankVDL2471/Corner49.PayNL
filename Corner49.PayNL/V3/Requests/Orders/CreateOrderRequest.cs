using System.Text.Json.Serialization;
using Corner49.PayNL.V2.DataTransferModels.Transaction;
using Corner49.PayNL.V3.DataTransferObjects.Orders;

namespace Corner49.PayNL.V3.Requests.Orders;

public class CreateOrderRequest {
	[JsonPropertyName("amount")]
	public Amount? Amount { get; set; }

	[JsonPropertyName("paymentMethod")]
	public V3PaymentMethod? PaymentMethod { get; set; }

	[JsonPropertyName("integration")]
	public Integration? Integration { get; set; }

	[JsonPropertyName("customer")]
	public V3Customer? Customer { get; set; }

	[JsonPropertyName("order")]
	public V3OrderInput? Order { get; set; }

	[JsonPropertyName("notification")]
	public V3Notification? Notification { get; set; }

	[JsonPropertyName("stats")]
	public Stats? Stats { get; set; }

	[JsonPropertyName("transferData")]
	public Dictionary<string, string>? TransferData { get; set; }

	[JsonPropertyName("serviceId")]
	public string? ServiceId { get; set; }

	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("reference")]
	public string? Reference { get; set; }

	[JsonPropertyName("expire")]
	public DateTime? Expire { get; set; }

	[JsonPropertyName("returnUrl")]
	public string? ReturnUrl { get; set; }

	[JsonPropertyName("exchangeUrl")]
	public string? ExchangeUrl { get; set; }
}
