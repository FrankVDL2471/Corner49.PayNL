using System.Text.Json.Serialization;
using Corner49.PayNL.V2.DataTransferModels.Authentication.AuthenticationTokens;
using Corner49.PayNL.V2.DataTransferModels.Transaction;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants.Clearings;

public class ClearingRecord {
	[JsonPropertyName("reportingId")]
	public string? ReportingId { get; set; }

	[JsonPropertyName("settlementCode")]
	public string? SettlementCode { get; set; }

	[JsonPropertyName("clearingId")]
	public string? ClearingId { get; set; }

	[JsonPropertyName("orderId")]
	public string? OrderId { get; set; }

	[JsonPropertyName("description")]
	public string? Description { get; set; }

	[JsonPropertyName("reference")]
	public string? Reference { get; set; }

	[JsonPropertyName("currencyAmount")]
	public Amount? CurrencyAmount { get; set; }

	[JsonPropertyName("amount")]
	public Amount? Amount { get; set; }

	[JsonPropertyName("paymentMethod")]
	public PaymentMethod? PaymentMethod { get; set; }

	
	[JsonPropertyName("turnoverGroup")]
	public TurnoverGroupMerchant? TurnoverGroup { get; set; }

	[JsonPropertyName("merchant")]
	public Merchant? Merchant { get; set; }


	[JsonPropertyName("transactionDate")]
	public DateTimeOffset? TransactionDate { get; set; }

	
}
