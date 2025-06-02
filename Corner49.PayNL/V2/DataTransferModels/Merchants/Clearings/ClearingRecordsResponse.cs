using System.Text.Json.Serialization;
using Corner49.PayNL.Utilities;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants.Clearings;

public class ClearingRecordsResponse {
	[JsonPropertyName("total")]
	public int Total { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }

	[JsonPropertyName("clearingRecords")]
	public List<ClearingRecord>? ClearingRecords { get; set; }

	[JsonPropertyName("_links")]
	public PaginatedLinks? Links { get; set; }
}
