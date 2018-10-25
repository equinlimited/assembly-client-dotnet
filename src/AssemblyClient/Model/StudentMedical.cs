using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class StudentMedical
	{
		[JsonProperty("dietary_needs")]
		public List<string> DietaryNeeds { get; set; }


		public StudentMedical()
		{
			this.DietaryNeeds = new List<string>();
		}
	}

}
