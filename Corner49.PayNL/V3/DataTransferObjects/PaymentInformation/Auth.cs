using System.Text.Json.Serialization;

namespace Corner49.PayNL.V3.DataTransferObjects.PaymentInformation;

public class Auth {
	/// <summary>
	/// If a 3DS authentication is available for the card, the 3DS transaction ID can be stored with the token.
	/// </summary>
	[JsonPropertyName("dsTransactionId")]
	public string? DsTransactionId { get; set; }
}
