using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class TelephoneNumber
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("telephone_number")]
		public string _TelephoneNumber { get; set; }

		[JsonProperty("is_primary")]
		public bool? IsPrimary { get; set; }


		public TelephoneNumber()
		{
		}
	}

}
