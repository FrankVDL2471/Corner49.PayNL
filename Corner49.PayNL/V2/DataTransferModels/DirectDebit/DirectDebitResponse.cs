using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.DirectDebit;

public class DirectDebitResponse {
	[JsonPropertyName("mandate")]
	public Mandate? Mandate { get; set; }

	[JsonPropertyName("directDebits")]
	public DirectDebit? DirectDebits { get; set; }
}