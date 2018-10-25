using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class AssessmentPoint
	{
		[JsonProperty("rank")]
		public int? Rank { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("year_code")]
		public string YearCode { get; set; }


		public AssessmentPoint()
		{
		}
	}

}
