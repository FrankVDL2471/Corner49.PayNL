using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Authentication;

public class Account {
	[JsonPropertyName("licenseCode")]
	public string? LicenseCode { get; set; }

	[JsonPropertyName("label")]
	public string? Label { get; set; }

	[JsonPropertyName("languageId")]
	public string? LanguageId { get; set; }

	[JsonPropertyName("logoutRedirectUrl")]
	public string? LogoutRedirectUrl { get; set; }
}
