using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Transaction;

public class Integration {
	[JsonPropertyName("testMode")]
	public bool TestMode { get; set; }
}
