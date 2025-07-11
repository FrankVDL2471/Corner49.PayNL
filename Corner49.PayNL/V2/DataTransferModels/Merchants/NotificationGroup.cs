using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants;

public class NotificationGroup {
	[JsonPropertyName("technical")]
	public bool Technical { get; set; }

	[JsonPropertyName("financial")]
	public bool Financial { get; set; }

	[JsonPropertyName("operations")]
	public bool Operations { get; set; }
}