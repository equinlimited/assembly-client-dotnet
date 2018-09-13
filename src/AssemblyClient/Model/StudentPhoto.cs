using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class StudentPhoto
	{
		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("hash")]
		public string Hash { get; set; }


		public StudentPhoto()
		{
		}
	}
}
