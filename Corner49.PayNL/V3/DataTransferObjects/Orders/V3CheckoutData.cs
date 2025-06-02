using System.Text.Json.Serialization;
using Corner49.PayNL.V2.DataTransferModels.Transaction;

namespace Corner49.PayNL.V3.DataTransferObjects.Orders;

public class V3CheckoutData {
	[JsonPropertyName("customer")]
	public Customer? Customer { get; set; }

	[JsonPropertyName("invoiceAddress")]
	public V3Address? InvoiceAddress { get; set; }

	[JsonPropertyName("shippingAddress")]
	public V3Address? ShippingAddress { get; set; }
}
