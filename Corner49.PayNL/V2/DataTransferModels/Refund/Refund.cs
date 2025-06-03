namespace Corner49.PayNL.V2.DataTransferModels.Refund
{
	public class Refund
	{
		public string? PaymentSessionId { get; set; }
		public int? Amount { get; set; }
		public string? Description { get; set; }
		public string? BankaccountHolder { get; set; }
		public string? BankaccountNumber { get; set; }
		public string? BankaccountBic { get; set; }
		public int? StatusCode { get; set; }
		public string? StatusName { get; set; }
		public string? ProcessedDate { get; set; }
	}
}
