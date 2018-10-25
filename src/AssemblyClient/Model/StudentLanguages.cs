using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class StudentLanguages
	{
		[JsonProperty("home_language_code")]
		public string HomeLanguageCode { get; set; }

		[JsonProperty("home_language_name")]
		public string HomeLanguageName { get; set; }

		[JsonProperty("first_language_code")]
		public string FirstLanguageCode { get; set; }

		[JsonProperty("first_language_name")]
		public string FirstLanguageName { get; set; }

		[JsonProperty("proficiency_in_english_code")]
		public string ProficiencyInEnglishCode { get; set; }

		[JsonProperty("proficiency_in_english_name")]
		public string ProficiencyInEnglishName { get; set; }


		public StudentLanguages()
		{
		}
	}

}
