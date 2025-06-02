using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Licenses;

public class LicenseRequest {
	/// <summary>
	/// The merchant id of your company starting with M.
	/// </summary>
	[JsonPropertyName("merchantCode")]
	public string? MerchantCode { get; set; }

	[JsonPropertyName("person")]
	public PersonLicense? Person { get; set; }
}
