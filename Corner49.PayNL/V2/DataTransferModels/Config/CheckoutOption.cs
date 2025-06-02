using Corner49.PayNL.V2.DataTransferModels.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Config {
	

	public class CheckoutOption {
		[JsonPropertyName("tag")]
		public string? Tag { get; set; }
		[JsonPropertyName("name")]
		public string? Name { get; set; }
		[JsonPropertyName("image")]
		public string? Image { get; set; }

		[JsonPropertyName("paymentMethods")]
		public IEnumerable<PaymentMethod>? PaymentMethods { get; set; }
	}



}
