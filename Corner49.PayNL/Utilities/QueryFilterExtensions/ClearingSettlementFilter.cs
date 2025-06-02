using Corner49.PayNL.Utilities;

namespace Corner49.PayNL.Utilities.QueryFilterExtensions;

/// <summary>
/// Used to build the query parameters for ClearingLines endpoint.
/// </summary>
public class ClearingSettlementFilter : QueryParamFilter<ClearingSettlementFilter> {

	/// <summary>
	/// Filter for a specific clearing ID.
	/// </summary>
	public ClearingSettlementFilter WithClearingId(string clearingId) {
		_filters["clearingId[eq]"] = clearingId;
		return this;
	}

	/// <summary>
	/// Filter for a specific merchant code
	/// </summary>
	public ClearingSettlementFilter WithMerchant(string merchantCode) {
		_filters["merchant[eq]"] = merchantCode;
		return this;
	}

	/// <summary>
	/// Filter for a specific merchant code
	/// </summary>
	public ClearingSettlementFilter WithSettlementCode(string settlementCode) {
		_filters["settlementCode[eq]"] = settlementCode;
		return this;
	}


}
