using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Licenses;

public class LicensesBrowseResponse {
	[JsonPropertyName("total")]
	public int Total { get; set; }

	[JsonPropertyName("licenses")]
	public List<LicenseResponse>? Licenses { get; set; }
}
