using Corner49.PayNL.Tests.Helpers;
using Corner49.PayNL.V2.DataTransferModels.Transaction;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
namespace Corner49.PayNL.Tests.V2;

public class Transactions {
	[Fact]
	public async Task CreateTransaction() {
		var client = TestHelper.CreateClientV2();

		var trx = await client.CreateTransaction(new CreateTransactionRequest {
			Amount = new Amount {
				Value = 1000,
			},
			ReturnUrl = "https://demo.pay.nl/complete/",
			Integration = new Integration {  TestMode = true }
		});

		Assert.NotNull(trx);
		Assert.NotNull(trx.Id);
		Assert.NotNull(trx.Amount);
		Assert.Equal(1000, trx.Amount.Value);
	}

	[Fact]
	public async Task ViewTransaction() {
		var client = TestHelper.CreateClientV2();

		var trx = await client.CreateTransaction(new CreateTransactionRequest {
			Amount = new Amount {
				Value = 1000,
			},
			ReturnUrl = "https://demo.pay.nl/complete/",
			Integration = new Integration { TestMode = true }
		});

		var trxInfo = await client.GetTransactionInfo(trx.OrderId!);
		Assert.Equal(trx.Id, trxInfo.Id);
		Assert.Equal(trx.Amount!.Value, trxInfo.Amount!.Value);
		Assert.Equal(trx.CreatedAt, trxInfo.CreatedAt);
	}

	[Fact]
	public async Task CanCancel() {
		var client = TestHelper.CreateClientV2();

		var trx = await client.CreateTransaction(new CreateTransactionRequest {
			Amount = new Amount {
				Value = 1000,
			},
			ReturnUrl = "https://demo.pay.nl/complete/",
			Integration = new Integration { TestMode = true }
		});

		await client.CancelTransaction(trx.Id!);
		var trxInfo = await client.GetTransactionInfo(trx.Id!);
		Assert.Equal(-90, trxInfo.Status!.Code);
	}

	[Fact()]
	public async Task CanRefund() {
		var client = TestHelper.CreateClientV2();

		//var trx = await client.CreateTransaction(new CreateTransactionRequest {
		//	Amount = new Amount {
		//		Value = 2000,
		//	},
		//	ReturnUrl = "https://demo.pay.nl/complete/",
		//	Integration = new Integration { TestMode = true }
		//});
		string trxId = "EX-3524-1057-8882";

		var approve = await client.ApproveTransaction(trxId);

		var refundResponse = await client.RefundTransaction(trxId, new RefundTransactionRequest {
			Amount = new Amount {
				Value = 1000,
			},
		});

		Assert.Equal(1000, refundResponse.Amount!.Value);

		var trxInfo = await client.GetTransactionInfo(trxId);
		Assert.Equal(1000, trxInfo.AmountRefunded!.Value);
	}

	[Fact(Skip = "Required paid transaction")]
	public async Task CanDecline() {
		var client = TestHelper.CreateClientV2();

		var trx = await client.CreateTransaction(new CreateTransactionRequest {
			Amount = new Amount {
				Value = 2000,
			},
			ReturnUrl = "https://demo.pay.nl/complete/",
			Integration = new Integration { TestMode = true }
		});
		await client.DeclineTransaction(trx.Id!);

		var trxInfo = await client.GetTransactionInfo(trx.Id!);
		Assert.Equal(-90, trxInfo.Status!.Code);
	}
}
