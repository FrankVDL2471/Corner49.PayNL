using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.DirectDebit;

public class MandateResultResponse {
	[JsonPropertyName("mandate")]
	public MandateInfoResponse? Mandate { get; set; }

	[JsonPropertyName("directDebit")]
	public List<MandateDirectDebitInfoResponse>? DirectDebits { get; set; }
}
