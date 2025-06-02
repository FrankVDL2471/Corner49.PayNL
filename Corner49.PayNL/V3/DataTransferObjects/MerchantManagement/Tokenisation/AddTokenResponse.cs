using System.Text.Json.Serialization;
using Corner49.PayNL.V2.Idin.Responses;

namespace Corner49.PayNL.V3.DataTransferObjects.MerchantManagement.Tokenisation;

public class AddTokenResponse {
	[JsonPropertyName("request")]
	public Request? Requests { get; set; }

	[JsonPropertyName("request")]
	public Token? Token { get; set; }
}
