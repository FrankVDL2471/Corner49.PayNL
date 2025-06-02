using Corner49.PayNL.Tests.Helpers;


#pragma warning disable CS8604 // Possible null reference argument.

namespace Corner49.PayNL.Tests.V2;

public class PaymentMethods {
	[Fact]
	public async Task CanGetPaymentMethods() {
		var client = TestHelper.CreateClientV2();

		var methods = await client.GetAllPaymentMethods();

		Assert.NotNull(methods);
		Assert.NotEmpty(methods.PaymentMethods);
		Assert.True(methods.Total > 0);
	}
}