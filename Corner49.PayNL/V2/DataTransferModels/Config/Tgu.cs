using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Config;

public class Tgu {
	[JsonPropertyName("ID")]
	public int? Id { get; set; }

	[JsonPropertyName("share")]
	public int? Share { get; set; }

	[JsonPropertyName("domain")]
	public string? Domain { get; set; }

	[JsonPropertyName("status")]
	public string? Status { get; set; }
}