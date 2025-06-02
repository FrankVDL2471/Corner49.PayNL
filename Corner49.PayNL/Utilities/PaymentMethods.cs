using System;
using System.Collections.Generic;
using System.Text;

namespace Corner49.PayNL.Utilities {
	public static class PaymentMethods {

		private readonly static KeyValuePair<int, string>[] _paymentMethods = new KeyValuePair<int, string>[] {
			new KeyValuePair<int, string>(10, "ideal"),
			new KeyValuePair<int, string>(436, "bancontact"),
			new KeyValuePair<int, string>(2277, "applepay"),
			new KeyValuePair<int, string>(2558, "googlepay"),
			new KeyValuePair<int, string>(706, "creditcard"),
			new KeyValuePair<int, string>(712, "maestro"),
			new KeyValuePair<int, string>(2379, "payconiq"),
		};

		public static int? GetPaymentMethodId(string name) {
			string nm = name.Replace(" ", "").ToLowerInvariant();

			foreach (var kv in _paymentMethods) {
				if (kv.Value.Equals(nm, StringComparison.OrdinalIgnoreCase)) return kv.Key;
			}
			return null;
		}

		public static string GetPaymentMethodName(int id) {
			foreach (var kv in _paymentMethods) {
				if (kv.Key == id) return kv.Value;
			}
			return null;
		}
	}
}
