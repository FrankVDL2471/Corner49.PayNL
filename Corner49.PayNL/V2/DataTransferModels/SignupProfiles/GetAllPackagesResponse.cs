using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.SignupProfiles;

public class GetAllPackagesResponse {
	[JsonPropertyName("total")]
	public int? Total { get; set; }

	[JsonPropertyName("packages")]
	public List<Package>? Packages { get; set; }
}