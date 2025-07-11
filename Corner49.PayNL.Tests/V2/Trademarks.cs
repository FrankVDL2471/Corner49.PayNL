using Corner49.PayNL.Tests.Helpers;
using Corner49.PayNL.V2.DataTransferModels.Trademarks;

namespace Corner49.PayNL.Tests.V2;

public class Trademarks {
	[Fact(Skip = "No rights to access this endpoint")]
	public async Task CanGetTrademarks() {
		var client = TestHelper.CreateClientV2();

		var trademarks = await client.GetAllTrademarks();

		Assert.NotNull(trademarks);
		Assert.NotEmpty(trademarks.Trademarks!);
		Assert.True(trademarks.Total > 0);
		Assert.Equal(trademarks.Total, trademarks.Trademarks!.Count());
	}

	[Fact(Skip = "No rights to access this endpoint")]
	public async Task CanGetTrademark() {
		var client = TestHelper.CreateClientV2();

		var trademarks = await client.GetAllTrademarks();
		var trademark = await client.GetTrademark(trademarks.Trademarks!.First().Code!);

		Assert.NotNull(trademark);
		Assert.Equal(trademarks.Trademarks!.First().Code, trademark.Code);
	}

	[Fact(Skip = "No rights to access this endpoint")]
	public async Task CanCreateTrademark() {
		var client = TestHelper.CreateClientV2();

		var created = await client.CreateTrademark(new CreateTrademarkRequest {
			Name = "Test Trademark",
		});

		var trademark = await client.GetTrademark(created.Code!);

		Assert.Equal(created, trademark);
	}

	[Fact(Skip = "No rights to access this endpoint")]
	public async Task CanSuspendAndUnsuspend() {
		var client = TestHelper.CreateClientV2();

		var created = await client.CreateTrademark(new CreateTrademarkRequest {
			Name = "Test Trademark",
		});

		await client.SuspendTrademark(created.Code!);
		var trademark = await client.GetTrademark(created.Code!);

		Assert.Equal("SUSPENDED", trademark.Status);

		await client.UnsuspendTrademark(created.Code!);
		trademark = await client.GetTrademark(created.Code!);
		Assert.Equal("ACTIVE", trademark.Status);
	}
}