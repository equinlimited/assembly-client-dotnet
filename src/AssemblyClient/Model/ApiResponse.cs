using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class ApiResponse
	{
		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("data")]
		public List<Result> Data { get; set; }

		[JsonProperty("errors")]
		public List<string> Errors { get; set; }


		public ApiResponse()
		{
			this.Data = new List<Result>();
			this.Errors = new List<string>();
		}
	}

}
