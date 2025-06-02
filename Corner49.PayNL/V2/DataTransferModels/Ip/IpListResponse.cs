using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Ip;

public class IpListResponse {
	[JsonPropertyName("total")]
	public int? Total { get; set; }

	[JsonPropertyName("ipAddresses")]
	public List<string>? IpAddresses { get; set; }
}
