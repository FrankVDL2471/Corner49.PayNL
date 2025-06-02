using Corner49.PayNL.V2.DataTransferModels.Merchants;
using System.Text.Json.Serialization;

public class Clearingaccount {
	[JsonPropertyName("method")]
	public string Method { get; set; }

	[JsonPropertyName("iban")]
	public Iban Iban { get; set; }
}
