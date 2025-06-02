using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Trademarks;

public class TrademarkListResponse {
	[JsonPropertyName("total")]
	public int? Total { get; set; }

	[JsonPropertyName("trademarks")]
	public List<TrademarkResponse>? Trademarks { get; set; }
}