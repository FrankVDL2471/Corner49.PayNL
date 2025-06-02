using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Authentication;

public class AuthenticateLoginResponse {
	[JsonPropertyName("session")]
	public Session? Session { get; set; }

	[JsonPropertyName("_links")]
	public List<Link>? Links { get; set; }
}
