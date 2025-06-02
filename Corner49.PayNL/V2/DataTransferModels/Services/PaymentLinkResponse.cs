using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Services;

public class PaymentLinkResponse {
	[JsonPropertyName("url")]
	public string? Url { get; set; }

	[JsonPropertyName("securityMode")]
	public int? SecurityMode { get; set; }
}
