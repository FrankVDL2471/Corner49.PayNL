using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels;

public class Link {
	[JsonPropertyName("href")]
	public string? Href { get; set; }

	[JsonPropertyName("rel")]
	public string? Rel { get; set; }

	[JsonPropertyName("type")]
	public string? Type { get; set; }
}
