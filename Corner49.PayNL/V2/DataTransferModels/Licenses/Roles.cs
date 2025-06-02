using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Licenses;

public class Roles {
	[JsonPropertyName("primaryContactPerson")]
	public bool? PrimaryContactPerson { get; set; }

	[JsonPropertyName("internalAdministrator")]
	public bool? InternalAdministrator { get; set; }
}
