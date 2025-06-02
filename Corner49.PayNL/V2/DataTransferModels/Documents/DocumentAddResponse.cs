using Corner49.PayNL.V2.DataTransferModels;
using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Documents;

public class DocumentAddResponse {
	[JsonPropertyName("document")]
	public Document? Document { get; set; }

	[JsonPropertyName("_links")]
	public List<Link>? Links { get; set; }
}
