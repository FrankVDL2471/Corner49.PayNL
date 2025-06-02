using System.Text.Json.Serialization;

namespace Corner49.PayNL.V3.Requests.Orders.InputMethods;

public class PinInput : V3InputMethod {
	[JsonPropertyName("terminalCode")]
	public string TerminalCode { get; set; }
}
