using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class Contact
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("middle_name")]
		public string MiddleName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("gender")]
		public string Gender { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("salutation")]
		public string Salutation { get; set; }

		[JsonProperty("emails")]
		public List<Email> Emails { get; set; }

		[JsonProperty("telephone_numbers")]
		public List<TelephoneNumber> TelephoneNumbers { get; set; }

		[JsonProperty("students")]
		public List<Student> Students { get; set; }


		public Contact()
		{
			this.Emails = new List<Email>();
			this.TelephoneNumbers = new List<TelephoneNumber>();
			this.Students = new List<Student>();
		}
	}
}
