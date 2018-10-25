using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class StaffMemberDemographics
	{
		[JsonProperty("ethnicity_code")]
		public string EthnicityCode { get; set; }

		[JsonProperty("ethnicity_group")]
		public string EthnicityGroup { get; set; }

		[JsonProperty("gender")]
		public string Gender { get; set; }

		[JsonProperty("disability")]
		public string Disability { get; set; }


		public StaffMemberDemographics()
		{
		}
	}

}
