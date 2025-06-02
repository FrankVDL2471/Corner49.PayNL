using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Services;

public class ServiceListResponse {
	[JsonPropertyName("total")]
	public int? Total { get; set; }

	[JsonPropertyName("services")]
	public List<Service>? Services { get; set; }
}