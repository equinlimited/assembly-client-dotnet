using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class StaffAllowance
	{
		[JsonProperty("additional_payment_type")]
		public string AdditionalPaymentType { get; set; }

		[JsonProperty("additional_payment_amount")]
		public string AdditionalPaymentAmount { get; set; }

		[JsonProperty("start_date")]
		public DateTime? StartDate { get; set; }

		[JsonProperty("end_date")]
		public DateTime? EndDate { get; set; }


		public StaffAllowance()
		{
		}
	}

}
