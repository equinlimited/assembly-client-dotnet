using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class StaffMemberQualificationInfo
	{
		[JsonProperty("teacher_number")]
		public string TeacherNumber { get; set; }

		[JsonProperty("qt_status")]
		public bool? QtStatus { get; set; }

		[JsonProperty("hlta_status")]
		public bool? HltaStatus { get; set; }

		[JsonProperty("qts_route")]
		public string QtsRoute { get; set; }

		[JsonProperty("qualifications")]
		public List<StaffQualification> Qualifications { get; set; }


		public StaffMemberQualificationInfo()
		{
			this.Qualifications = new List<StaffQualification>();
			this.Qualifications = new List<StaffQualification>();
		}
	}

}
