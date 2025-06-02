using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.PaymentMethods;

public class PaymentMethodCollection {
	[JsonPropertyName("total")]
	public int? Total { get; set; }

	[JsonPropertyName("paymentMethods")]
	public List<PaymentMethod>? PaymentMethods { get; set; }
}