using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class StaffAbsence
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("staff_member_id")]
		public int? StaffMemberId { get; set; }

		[JsonProperty("start_date")]
		public DateTime? StartDate { get; set; }

		[JsonProperty("end_date")]
		public DateTime? EndDate { get; set; }

		[JsonProperty("working_days_lost")]
		public float? WorkingDaysLost { get; set; }

		[JsonProperty("absence_category")]
		public string AbsenceCategory { get; set; }

		[JsonProperty("illness_category")]
		public string IllnessCategory { get; set; }

		[JsonProperty("pay_rate")]
		public string PayRate { get; set; }


		public StaffAbsence()
		{
		}
	}

}
