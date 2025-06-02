using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Transaction;

public class Customer {
	[JsonPropertyName("firstName")]
	public string? FirstName { get; set; } // The forename (also known as a given name, Christian name or a first name).

	[JsonPropertyName("lastName")]
	public string? LastName { get; set; } // The surname (also known as a family name or a last name).

	/// <summary>
	/// Either B for business or C for consumer.
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; set; }

	[JsonPropertyName("ipAddress")]
	public string? Ip { get; set; } // An ip address

	/// <summary>
	/// Date of birth as defined in ISO-8601.
	/// </summary>
	[JsonPropertyName("birthDate")]
	public string? BirthDate { get; set; }

	[JsonPropertyName("gender")]
	public string? Gender { get; set; } // The subject's gender. Choose either M for male or F for female.

	[JsonPropertyName("phone")]
	public string? Phone { get; set; } // The subject's phone number. Optionally prepended with a + and country code

	[JsonPropertyName("email")]
	public string? Email { get; set; } // An email address.

	[JsonPropertyName("language")]
	public string? Language { get; set; } // The language code consisting of 2 uppercase letters.


	/// <summary>
	/// Indicates whether you trust the payer, scale -10 -> 10 (10 Reliable, -10 Unreliable).
	/// </summary>
	[JsonPropertyName("trust")]
	public int? Trust { get; set; }


	/// <summary>
	/// Unique reference of the payer. This field only allows alphanumeric characters.
	/// </summary>
	[JsonPropertyName("reference")]
	public string? Reference { get; set; } 

	[JsonPropertyName("company")]
	public Company? Company { get; set; }

	[JsonPropertyName("bankAccount")]
	public PaymentBankAccount? BankAccount { get; set; }
}