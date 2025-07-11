using System.Text.Json.Serialization;
using Corner49.PayNL.Utilities;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants.InvoiceLines;

public class InvoiceLinesResponse {
	[JsonPropertyName("total")]
	public int Total { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }

	[JsonPropertyName("invoiceLines")]
	public List<InvoiceLines>? InvoiceLines { get; set; }

	[JsonPropertyName("_links")]
	public PaginatedLinks? Links { get; set; }

}
