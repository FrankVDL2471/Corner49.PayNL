using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Refund
{
	public class RefundInfoResponse
	{

		[JsonPropertyName("request")]
		public Error? Request { get; set; }
		public Refund? Refund { get; set; }
	}
}
