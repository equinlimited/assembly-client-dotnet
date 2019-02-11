using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class SchoolStatus
	{
		[JsonProperty("last_changes_at")]
		public string LastChangesAt { get; set; }

		[JsonProperty("last_sync_at")]
		public string LastSyncAt { get; set; }

		[JsonProperty("last_sync_status")]
		public string LastSyncStatus { get; set; }


		public SchoolStatus()
		{
		}
	}

}
