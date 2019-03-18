using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class AcademicYear
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("start_date")]
		public DateTime? StartDate { get; set; }

		[JsonProperty("end_date")]
		public DateTime? EndDate { get; set; }

		[JsonProperty("terms")]
		public List<AcademicYearTerms> Terms { get; set; }


		public AcademicYear()
		{
			this.Terms = new List<AcademicYearTerms>();
		}
	}

}
