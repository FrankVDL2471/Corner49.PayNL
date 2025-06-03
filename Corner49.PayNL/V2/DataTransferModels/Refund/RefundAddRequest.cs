using System;
using System.Collections.Generic;
using System.Text;

namespace Corner49.PayNL.V2.DataTransferModels.Refund
{
	/// <summary>
	/// A refund, not based on a previous transaction, but to another IBAN.
	/// If you are looking for a normal refund, use <seealso cref="Transaction.TransactionRefundRequest"/>
	/// </summary>
	public class RefundAddRequest
	{

		public RefundAddRequest() { 
		}

		/// <summary>
		/// A refund is the repayment of (part of) a transaction to the end user.
		/// </summary>
		/// <param name="amount"></param>
		/// <param name="bankAccountHolder"></param>
		/// <param name="bankAccountNumber"></param>
		/// <param name="bankAccountBic"></param>
		public RefundAddRequest(decimal amount, string bankAccountHolder, string bankAccountNumber)
		{
			Amount = (int)Math.Floor(amount * 100);
			BankAccountHolder = bankAccountHolder;
			BankAccountNumber = bankAccountNumber;
		}

		public string ServiceId { get; set; }


		/// <summary>
		/// The amount to be paid should be given in cents. For example € 3.50 becomes 350.
		/// </summary>
		public int Amount { get; set; }

		/// <summary>
		/// The name of the customer.
		/// </summary>
		public string BankAccountHolder { get; set; }

		/// <summary>
		/// The bankaccount number of the customer.
		/// </summary>
		public string BankAccountNumber { get; set; }

		/// <summary>
		/// The BIC of the bank.
		/// </summary>
		public string BankAccountBic { get; set; }

		/// <summary>
		/// The description to include with the payment.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The id of a promotor / affiliate.
		/// In general, you won't use this unless you know the ID's of your affiliate's
		/// </summary>
		public int? PromotorId { get; set; }

		/// <summary>
		/// The used tool code.
		/// </summary>
		public string Tool { get; set; }

		/// <summary>
		/// The used info code which can be tracked in the stats
		/// </summary>
		public string Info { get; set; }

		/// <summary>
		/// The used object.
		/// </summary>
		public string Object { get; set; }

		/// <summary>
		/// The first free value which can be tracked in the stats
		/// </summary>
		public string Extra1 { get; set; }

		/// <summary>
		/// The second free value which can be tracked in the stats
		/// </summary>
		public string Extra2 { get; set; }

		/// <summary>
		/// The third free value which can be tracked in the stats
		/// </summary>
		public string Extra3 { get; set; }

		/// <summary>
		/// id from the payment
		/// </summary>
		public string OrderId { get; set; }

		/// <summary>
		/// The currency of the amount, default is EUR.
		/// </summary>
		public string Currency { get; set; }

		/// <summary>
		/// The currency of the amount, default is EUR.
		/// </summary>
		public DateTime? ProcessDate { get; set; }


	}
}
