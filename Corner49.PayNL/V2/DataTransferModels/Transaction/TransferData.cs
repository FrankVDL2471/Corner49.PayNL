using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Transaction;

public class TransferData {
	[JsonPropertyName("name")]
	public string? Name { get; set; } // The name of the variable to be tracked in the transaction.

	[JsonPropertyName("value")]
	public string? Value { get; set; } // The value of the variable to be tracked in the transaction.
}