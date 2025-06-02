using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Transaction;

public class CaptureTransactionRequest {
	/// <summary>
	/// Amount in cents
	/// </summary>
	[JsonPropertyName("amount")]
	public float? Amount { get; set; }

	/// <summary>
	/// Key is the ID of the product, value is the quantity
	/// </summary>
	[JsonPropertyName("products")]
	public Dictionary<string, int>? Products { get; set; }
}