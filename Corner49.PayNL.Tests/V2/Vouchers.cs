using Corner49.PayNL.Tests.Helpers;
using Corner49.PayNL.V2.DataTransferModels.Transaction;
using Corner49.PayNL.V2.DataTransferModels.Vouchers;

namespace Corner49.PayNL.Tests.V2;

public class Vouchers {
	[Fact(Skip = "Broken on API side")]
	public async Task CreateVoucher() {
		var client = TestHelper.CreateClientV2();

		var response = await client.CreateVoucher(new VoucherCreationRequest {
			Transaction = new Transaction {
				Type = "ECOM",
				Amount = new Amount {
					Value = 1000,
				}
			},
			Voucher = new Voucher {
				CardNumber = "12345678",
				PinCode = "5087"
			},

		});

		Assert.NotNull(response);
	}
}