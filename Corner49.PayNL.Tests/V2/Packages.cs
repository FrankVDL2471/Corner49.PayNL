using Corner49.PayNL.Tests.Helpers;


#pragma warning disable CS8604 // Possible null reference argument.

namespace Corner49.PayNL.Tests.V2;

public class Packages {
	[Fact]
	public async Task ListPackages() {
		var client = TestHelper.CreateClientV2();

		var packages = await client.GetAllPackages();

		Assert.NotNull(packages);
		Assert.NotEmpty(packages.Packages);
		Assert.True(packages.Total > 0);
		Assert.Equal(packages.Total, packages.Packages.Count);
	}
}