using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Transaction;

public class Refund {
	[JsonPropertyName("id")]
	public string? Id { get; set; }
}