using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants;

public class MerchantListResponse {
	[JsonPropertyName("total")]
	public int Total { get; set; }

	[JsonPropertyName("merchants")]
	public List<MerchantResponse>? Merchants { get; set; }
}