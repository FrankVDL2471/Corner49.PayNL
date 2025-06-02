using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.ContactMethods;

public class CreateContactMethodsRequest {
	[JsonPropertyName("merchantCode")]
	public string? MerchantCode { get; set; }

	[JsonPropertyName("contactMethod")]
	public ContactMethod? ContactMethod { get; set; }
}
