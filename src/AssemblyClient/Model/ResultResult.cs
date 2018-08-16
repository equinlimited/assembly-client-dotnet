using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class ResultResult
	{
		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("data")]
		public List<Result> Data { get; set; }

	}
}
