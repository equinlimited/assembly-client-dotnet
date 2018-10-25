using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class Subject
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("mis_subjects")]
		public List<MisSubject> MisSubjects { get; set; }


		public Subject()
		{
			this.MisSubjects = new List<MisSubject>();
		}
	}

}
