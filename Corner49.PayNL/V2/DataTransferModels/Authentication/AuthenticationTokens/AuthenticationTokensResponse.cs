using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Authentication.AuthenticationTokens;

public class AuthenticationTokensResponse {
	[JsonPropertyName("total")]
	public int? Total { get; set; }

	[JsonPropertyName("authenticationTokens")]
	public List<AuthenticationTokenResponse>? AuthenticationTokens { get; set; }
}
