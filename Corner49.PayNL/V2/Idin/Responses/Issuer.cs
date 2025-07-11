using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.Idin.Responses;

public class Issuer {
	[JsonPropertyName("issuerId")]
	public string? IssuerId { get; set; }

	[JsonPropertyName("issuerName")]
	public string? IssuerName { get; set; }

	[JsonPropertyName("countryName")]
	public string? CountryName { get; set; }

	[JsonPropertyName("countryCode")]
	public string? CountryCode { get; set; }
}