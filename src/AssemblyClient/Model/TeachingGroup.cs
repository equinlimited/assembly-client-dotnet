using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class TeachingGroup
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("school_id")]
		public int? SchoolId { get; set; }

		[JsonProperty("source_id")]
		public string SourceId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("created_at")]
		public DateTime? CreatedAt { get; set; }

		[JsonProperty("updated_at")]
		public DateTime? UpdatedAt { get; set; }

		[JsonProperty("academic_year_id")]
		public int? AcademicYearId { get; set; }

		[JsonProperty("subject_id")]
		public int? SubjectId { get; set; }

		[JsonProperty("start_date")]
		public DateTime? StartDate { get; set; }

		[JsonProperty("end_date")]
		public DateTime? EndDate { get; set; }

		[JsonProperty("level")]
		public string Level { get; set; }

		[JsonProperty("assessment_id")]
		public int? AssessmentId { get; set; }


		public TeachingGroup()
		{
		}
	}
}
