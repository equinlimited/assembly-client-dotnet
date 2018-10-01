using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class StaffQualification
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("qualification_code")]
		public string QualificationCode { get; set; }

		[JsonProperty("degree_class")]
		public string DegreeClass { get; set; }

		[JsonProperty("first_subject_code")]
		public string FirstSubjectCode { get; set; }

		[JsonProperty("first_subject_name")]
		public string FirstSubjectName { get; set; }

		[JsonProperty("second_subject_code")]
		public string SecondSubjectCode { get; set; }

		[JsonProperty("second_subject_name")]
		public string SecondSubjectName { get; set; }


		public StaffQualification()
		{
		}
	}
}
