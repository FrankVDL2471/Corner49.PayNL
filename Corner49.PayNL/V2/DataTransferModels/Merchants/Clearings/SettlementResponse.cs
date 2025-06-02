using Corner49.PayNL.Utilities;

namespace Corner49.PayNL.V2.DataTransferModels.Merchants.Clearings {
	public class SettlementResponse {
		public int total { get; set; }
		public int count { get; set; }
		public int pages { get; set; }
		public Settlement[] settlements { get; set; }
		public PaginatedLinks _links { get; set; }
	}

}
