using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Vouchers;

public class Voucher {
	[JsonPropertyName("cardNumber")]
	public string? CardNumber { get; set; }

	[JsonPropertyName("pinCode")]
	public string? PinCode { get; set; }
}