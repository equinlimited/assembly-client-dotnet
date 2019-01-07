using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class DietaryNeed
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }


		public DietaryNeed()
		{
		}
	}

}
