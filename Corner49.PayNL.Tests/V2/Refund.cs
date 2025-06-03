using Corner49.PayNL.Tests.Helpers;
using Corner49.PayNL.V2.DataTransferModels.Refund;
using Corner49.PayNL.V2.DataTransferModels.Transaction;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
namespace Corner49.PayNL.Tests.V2;

public class Refund {
	[Fact]
	public async Task CreateRefund() {
		var client = TestHelper.CreateClientV2();

		var trx = await client.AddRefund(new RefundAddRequest(1, "Test Account", "BE88 7330 0210 6041"));

		Assert.NotNull(trx);
		Assert.NotNull(trx.RefundId);
	}

	[Fact]
	public async Task ViewRefund() {
		var client = TestHelper.CreateClientV2();

		var trx = await client.AddRefund(new RefundAddRequest(1, "Test Account", "BE88 7330 0210 6041"));


		var trxInfo = await client.GetRefund(trx.RefundId!);
		//Assert.Equal(trx.RefundId, trxInfo.Refund.);
		
	}


}
