using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Terminals;

public class TerminalListResponse {
	[JsonPropertyName("total")]
	public int? Total { get; set; }

	[JsonPropertyName("terminals")]
	public List<GetTerminalResponse>? Terminals { get; set; }
}