using Corner49.PayNL.V2.DataTransferModels;
using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.ClearingAccounts;

public class ClearingAccountBrowseResponse {
	[JsonPropertyName("total")]
	public int Total { get; set; }

	[JsonPropertyName("clearingAccounts")]
	public List<ClearingAccountResponse> ClearingAccounts { get; set; }

	[JsonPropertyName("_links")]
	public List<Link>? Links { get; set; }
}
