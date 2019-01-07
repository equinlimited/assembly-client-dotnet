using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {

	public class AttendanceSummary
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("student_id")]
		public int? StudentId { get; set; }

		[JsonProperty("registration_group_id")]
		public int? RegistrationGroupId { get; set; }

		[JsonProperty("academic_year_id")]
		public int? AcademicYearId { get; set; }

		[JsonProperty("start_date")]
		public DateTime? StartDate { get; set; }

		[JsonProperty("end_date")]
		public DateTime? EndDate { get; set; }

		[JsonProperty("possible_sessions")]
		public string PossibleSessions { get; set; }

		[JsonProperty("attended_sessions")]
		public string AttendedSessions { get; set; }

		[JsonProperty("late_sessions")]
		public string LateSessions { get; set; }

		[JsonProperty("authorised_absence_sessions")]
		public string AuthorisedAbsenceSessions { get; set; }

		[JsonProperty("unauthorised_absence_sessions")]
		public string UnauthorisedAbsenceSessions { get; set; }


		public AttendanceSummary()
		{
		}
	}

}
