using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants;

public class MerchantResponseWrapper {
	[JsonPropertyName("merchant")]
	public MerchantResponse? Merchant { get; set; }
}