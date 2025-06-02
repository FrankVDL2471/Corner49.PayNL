using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Terminals;

public class TerminalSupplier {
	[JsonPropertyName("id")]
	public int? Id { get; set; }

	[JsonPropertyName("name")]
	public string? Name { get; set; }

	[JsonPropertyName("terminalId")]
	public string? TerminalId { get; set; }
}
