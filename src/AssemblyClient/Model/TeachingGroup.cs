using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class TeachingGroup
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("start_date")]
		public DateTime? StartDate { get; set; }

		[JsonProperty("end_date")]
		public DateTime? EndDate { get; set; }

		[JsonProperty("supervisor_ids")]
		public List<int?> SupervisorIds { get; set; }

		[JsonProperty("student_ids")]
		public List<int?> StudentIds { get; set; }

		[JsonProperty("subject")]
		public Subject Subject { get; set; }

	}
}
