using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class StudentDemographics
	{
		[JsonProperty("ethnicity_code")]
		public string EthnicityCode { get; set; }

		[JsonProperty("ethnicity_group")]
		public string EthnicityGroup { get; set; }

		[JsonProperty("gender")]
		public string Gender { get; set; }

		[JsonProperty("is_pp")]
		public bool? IsPp { get; set; }

		[JsonProperty("is_eal")]
		public bool? IsEal { get; set; }

		[JsonProperty("sen_category")]
		public string SenCategory { get; set; }

		[JsonProperty("country_of_birth")]
		public string CountryOfBirth { get; set; }

		[JsonProperty("nationalities")]
		public List<string> Nationalities { get; set; }

		[JsonProperty("fsm_review_date")]
		public string FsmReviewDate { get; set; }

		[JsonProperty("is_fsm")]
		public bool? IsFsm { get; set; }

		[JsonProperty("looked_after")]
		public bool? LookedAfter { get; set; }

		[JsonProperty("ever_in_care")]
		public bool? EverInCare { get; set; }

		[JsonProperty("sen_needs")]
		public List<SenNeed> SenNeeds { get; set; }


		public StudentDemographics()
		{
			this.Nationalities = new List<string>();
			this.SenNeeds = new List<SenNeed>();
			this.SenNeeds = new List<SenNeed>();
		}
	}

}
