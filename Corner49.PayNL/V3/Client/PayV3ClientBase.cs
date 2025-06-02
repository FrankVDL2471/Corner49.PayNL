using Corner49.PayNL.Utilities;
using Corner49.PayNL.V2.Client;

namespace Corner49.PayNL.V3.Client;

public class PayV3ClientBase : PayV2ClientBase {
	protected PayV3ClientBase(string apiSecret, string at, string serviceId, HttpClient? httpClient = default, Action<PayRequestLog>? onRequest = default) : base(apiSecret, at, serviceId, httpClient, onRequest) {
	}

	protected override string ClientVersion => "2.0.0.0";
	protected override Core DefaultCore => new(new Uri("https://connect.payments.nl/v1/"), "Pay.nl (Default)");
}
