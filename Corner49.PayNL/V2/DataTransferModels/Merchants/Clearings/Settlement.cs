using Corner49.PayNL.V2.DataTransferModels.Authentication.AuthenticationTokens;
using Corner49.PayNL.V2.DataTransferModels.Transaction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants.Clearings {



	public class Settlement {
		[JsonPropertyName("code")]
		public string Code { get; set; }
		[JsonPropertyName("description")]
		public string Description { get; set; }
		[JsonPropertyName("settlementDate")]
		public DateTimeOffset? SettlementDate { get; set; }

		[JsonPropertyName("confirmationDate")]
		public DateTimeOffset? ConfirmationDate { get; set; }

		[JsonPropertyName("amount")]
		public Amount Amount { get; set; }

		[JsonPropertyName("baseAccountIban")]
		public string BaseAccountIban { get; set; }

		[JsonPropertyName("clearingAccount")]
		public Clearingaccount ClearingAccount { get; set; }

		[JsonPropertyName("clearings")]
		public List<Clearing> Clearings { get; set; }
	}

	public class Clearing {
		public string clearingId { get; set; }
		public Clearingline[] clearingLines { get; set; }
	}

	public class Clearingline {
		public string code { get; set; }
		public string clearingDate { get; set; }
		public string settlementDate { get; set; }
		public string valueDate { get; set; }
		public string state { get; set; }
		public TurnoverGroupMerchant turnoverGroup { get; set; }
		public ClearingLineType clearingLineType { get; set; }
		public Amount amount { get; set; }
		public Merchant merchant { get; set; }
		public int transactions { get; set; }
		public int uniquePayers { get; set; }
	}

} 