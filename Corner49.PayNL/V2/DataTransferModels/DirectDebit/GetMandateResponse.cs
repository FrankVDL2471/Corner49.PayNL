using System.Text.Json.Serialization;
using Corner49.PayNL.V2.Idin.Responses;

namespace Corner49.PayNL.V2.DataTransferModels.DirectDebit;

public class GetMandateResponse {
	[JsonPropertyName("request")]
	public Request? Request { get; set; }

	[JsonPropertyName("result")]
	public MandateResultResponse? Response { get; set; }
}
