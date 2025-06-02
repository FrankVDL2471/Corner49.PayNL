using System.Text.Json.Serialization;

namespace Corner49.PayNL.V3.DataTransferObjects.MerchantManagement.Tokenisation;

public class Token {
	[JsonPropertyName("id")]
	public string? Id { get; set; }

	[JsonPropertyName("hash")]
	public string? Hash { get; set; }
}
