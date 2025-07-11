using Corner49.PayNL.Tests.Helpers;


#pragma warning disable CS8604 // Possible null reference argument.

namespace Corner49.PayNL.Tests.V2;

public class Currencies {
	[Fact]
	public async Task GetCurrencies() {
		var client = TestHelper.CreateClientV2();
		var currencies = await client.GetAllCurrencies();
		Assert.NotNull(currencies);
		Assert.NotEmpty(currencies.Currencies);
		Assert.True(currencies.Total > 0);
		Assert.Equal(currencies.Total, currencies.Currencies.Count());
	}
}