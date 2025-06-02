using Corner49.PayNL.V2.Client;
using Corner49.PayNL.V2.Idin;
using Corner49.PayNL.V3.Client;
using Corner49.PayNL.V2.Client;
using Corner49.PayNL.V3.Client;

namespace Corner49.PayNL.Tests.Helpers;

public static class TestHelper {
	public static IPayV3Client CreateClientV3() {
		return new PayV3Client(Environment.GetEnvironmentVariable("PAY_APIKEY")!, Environment.GetEnvironmentVariable("PAY_AT")!, Environment.GetEnvironmentVariable("PAY_SERVICEID")!);
	}

	public static IPayV2Client CreateClientV2() {
		return new PayV2Client(Environment.GetEnvironmentVariable("PAY_APIKEY")!, Environment.GetEnvironmentVariable("PAY_AT")!, Environment.GetEnvironmentVariable("PAY_SERVICEID")!);
	}

	public static MultiCorePayV2Client CreatMultiCoreClient(HttpClient? httpClient = null) {
		var client = new MultiCorePayV2Client(Environment.GetEnvironmentVariable("PAY_APIKEY")!, Environment.GetEnvironmentVariable("PAY_AT")!, Environment.GetEnvironmentVariable("PAY_SERVICEID")!, httpClient);
		client.Initialize();
		return client;
	}

	public static IdinClient CreateIdinClient() {
		return new IdinClient(Environment.GetEnvironmentVariable("PAY_APIKEY")!, Environment.GetEnvironmentVariable("PAY_AT")!);
	}
}
