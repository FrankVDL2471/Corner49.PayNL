using System.Text.Json.Serialization;
using Corner49.PayNL.V2.DataTransferModels.Merchants;

namespace Corner49.PayNL.V2.DataTransferModels.Licenses;

public class PersonLicense : Person {
	[JsonPropertyName("roles")]
	public Roles? Roles { get; set; }
}
