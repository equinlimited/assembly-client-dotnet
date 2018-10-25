using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class Email
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("email")]
		public string _Email { get; set; }

		[JsonProperty("is_primary")]
		public bool? IsPrimary { get; set; }


		public Email()
		{
		}
	}

}
