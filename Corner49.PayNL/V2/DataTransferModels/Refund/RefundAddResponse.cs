using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Refund
{
	/// <summary>
	/// The response of a Refund Add call
	/// </summary>
	public class RefundAddResponse 
	{
		/// <summary>
		/// ID of the refund starting with 'RF-' (optional, emptyfor creditcard transactions)
		/// </summary>
		[JsonPropertyName("refundId")]
		public string? RefundId { get; set; }

		[JsonPropertyName("request")]
		public Error? Request { get; set; }


	}
}
