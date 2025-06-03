using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Transaction;

public class Amount {

	public Amount()
	{
		this.Currency = "EUR";
	}
	public Amount(decimal value) : this()
	{
		this.Value = (int)Math.Floor(value * 100);
	}

	// Amount in cents
	[JsonPropertyName("value")]
	public int? Value { get; set; }

	[JsonPropertyName("currency")]
	public string Currency { get; set; }
}