using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.PaymentMethods;

/// <summary>
///     Payment Method information
/// </summary>
public class PaymentMethod {
	/// <summary>
	///     Payment method ID
	/// </summary>
	[JsonPropertyName("id")]
	public int? Id { get; set; }

	/// <summary>
	///     Payment method name
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; set; }


	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("image")]
	public string? Image { get; set; }
}