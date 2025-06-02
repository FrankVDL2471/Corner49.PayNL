using Corner49.PayNL.Tests.Helpers;
using Corner49.PayNL.V2.DataTransferModels.Services;
using Corner49.PayNL.V2.DataTransferModels.Transaction;

namespace Corner49.PayNL.Tests.V2;

public class PaymentLink {
	[Fact]
	public async Task PaymentLinkCreate() {
		var client = TestHelper.CreateClientV2();

		var paymentLink = await client.PaymentLinkCreate(Environment.GetEnvironmentVariable("PAY_SERVICEID") ?? "", new PaymentLinkRequest {
			SecurityMode = 0,
			Language = "nl_NL",
			Amount = new Amount {
				Value = 1
			},
			AmountMin = new Amount {
				Value = 1
			},
		});

		Assert.NotNull(paymentLink);
		Assert.NotNull(paymentLink.Url);
		Assert.Equal(0, paymentLink.SecurityMode);
	}
}
