using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants;

public class CreateMerchantRequest {
	[JsonPropertyName("partner")]
	public CreateMerchantPartnerModel? Partner { get; set; }

	[JsonPropertyName("merchant")]
	public CreateMerchantModel? Merchant { get; set; }
}