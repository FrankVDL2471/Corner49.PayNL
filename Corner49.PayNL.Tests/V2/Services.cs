using Corner49.PayNL.Tests.Helpers;


#pragma warning disable CS8604 // Possible null reference argument.

namespace Corner49.PayNL.Tests.V2;

public class Services {
	[Fact]
	public async Task CanGetServices() {
		var client = TestHelper.CreateClientV2();

		var services = await client.GetAllServices();

		Assert.NotNull(services);
		Assert.NotEmpty(services.Services);
		Assert.True(services.Total > 0);
		Assert.Equal(services.Total, services.Services.Count);
	}
}