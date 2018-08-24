using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class StaffSalary
	{
		[JsonProperty("hours_per_week")]
		public string HoursPerWeek { get; set; }

		[JsonProperty("fte")]
		public string Fte { get; set; }

		[JsonProperty("weeks_per_year")]
		public string WeeksPerYear { get; set; }

		[JsonProperty("pay_range")]
		public string PayRange { get; set; }

		[JsonProperty("start_date")]
		public DateTime? StartDate { get; set; }

		[JsonProperty("end_date")]
		public DateTime? EndDate { get; set; }

		[JsonProperty("pay_scale_framework")]
		public string PayScaleFramework { get; set; }

		[JsonProperty("regional_spine")]
		public string RegionalSpine { get; set; }

		[JsonProperty("base_pay")]
		public string BasePay { get; set; }

		[JsonProperty("actual_pay")]
		public string ActualPay { get; set; }

		[JsonProperty("safeguarded_salary")]
		public bool? SafeguardedSalary { get; set; }


		public StaffSalary()
		{
		}
	}
}
