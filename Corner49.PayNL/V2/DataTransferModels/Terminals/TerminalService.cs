using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Terminals;

public class TerminalService {
	[JsonPropertyName("code")]
	public string? Code { get; set; }

	[JsonPropertyName("status")]
	public string? Status { get; set; }

	[JsonPropertyName("name")]
	public string? Name { get; set; }
}