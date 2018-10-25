using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class CalendarEvent
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("start_date")]
		public DateTime? StartDate { get; set; }

		[JsonProperty("end_date")]
		public DateTime? EndDate { get; set; }

		[JsonProperty("is_active")]
		public bool? IsActive { get; set; }

		[JsonProperty("is_recurrent")]
		public bool? IsRecurrent { get; set; }

		[JsonProperty("mis_type")]
		public CalendarEventMisType MisType { get; set; }


		public CalendarEvent()
		{
		}
	}

}
