using System.Text.Json.Serialization;
using Corner49.PayNL.V2.DataTransferModels.Merchants;

namespace Corner49.PayNL.V2.DataTransferModels.Authentication.AuthenticationTokens;

public class AuthenticationTokenCreateRequest {
	[JsonPropertyName("merchantCode")]
	public string? MerchantCode { get; set; }

	[JsonPropertyName("authenticationToken")]
	public AuthenticationToken AuthenticationToken { get; set; }

	[JsonPropertyName("ipFilter")]
	public IpFilter IpFilter { get; set; }
}
