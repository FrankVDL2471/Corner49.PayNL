using System.Text.Json.Serialization;
using Corner49.PayNL.V2.DataTransferModels.Transaction;
using Corner49.PayNL.V3.DataTransferObjects.PaymentInformation;

namespace Corner49.PayNL.V3.DataTransferObjects.MerchantManagement.Tokenisation;

public class AddTokenRequest {
	[JsonPropertyName("payment")]
	public Payment? Payment { get; set; }

	[JsonPropertyName("options")]
	public Options? Options { get; set; }

	[JsonPropertyName("customer")]
	public Customer? Customer { get; set; }
}
