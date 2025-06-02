using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants;

public class IpFilter {
	[JsonPropertyName("Type")]
	public string? Type { get; set; }

	[JsonPropertyName("exceptionList")]
	public List<string>? ExceptionList { get; set; }
}
