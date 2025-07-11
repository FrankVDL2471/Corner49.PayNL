using Corner49.PayNL.Tests.Helpers;

namespace Corner49.PayNL.Tests.V2;

public class PaymentIssuers {
	[Fact]
	public async Task ListIssuersMc() {
		var client = TestHelper.CreateClientV2();

		var packages = await client.GetAllPaymentIssuers();

		Assert.NotNull(packages);
		Assert.NotEmpty(packages.Issuers!);
		Assert.True(packages.Total > 0);
		Assert.Equal(packages.Total, packages.Issuers!.Count);
	}

	[Fact]
	public async Task ListIssuersForIdMc() {
		var client = TestHelper.CreateClientV2();

		var packages = await client.GetAllPaymentIssuersForId(10);

		Assert.NotNull(packages);
		Assert.NotEmpty(packages.Issuers!);
		Assert.True(packages.Total > 0);
		Assert.NotEqual(packages.Total, packages.Issuers!.Count);
		Assert.True(packages.Issuers!.All(x => x.PaymentMethod!.Id == 10));
	}
}
