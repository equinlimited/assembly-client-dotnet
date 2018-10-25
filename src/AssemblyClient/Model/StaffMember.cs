using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class StaffMember
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("mis_id")]
		public string MisId { get; set; }

		[JsonProperty("staff_code")]
		public string StaffCode { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("legal_first_name")]
		public string LegalFirstName { get; set; }

		[JsonProperty("middle_name")]
		public string MiddleName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("legal_last_name")]
		public string LegalLastName { get; set; }

		[JsonProperty("former_last_name")]
		public string FormerLastName { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("dob")]
		public DateTime? Dob { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("is_teaching_staff")]
		public bool? IsTeachingStaff { get; set; }

		[JsonProperty("included_in_census")]
		public bool? IncludedInCensus { get; set; }

		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		[JsonProperty("end_date")]
		public string EndDate { get; set; }

		[JsonProperty("demographics")]
		public List<StaffMemberDemographics> Demographics { get; set; }

		[JsonProperty("qualification_info")]
		public List<StaffMemberQualificationInfo> QualificationInfo { get; set; }


		public StaffMember()
		{
			this.Demographics = new List<StaffMemberDemographics>();
			this.QualificationInfo = new List<StaffMemberQualificationInfo>();
		}
	}

}
