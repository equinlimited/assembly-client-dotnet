using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class Attendance
  {
    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("student_id")]
    public int? StudentId { get; set; }

    [JsonProperty("registration_group_id")]
    public int? RegistrationGroupId { get; set; }

    [JsonProperty("session_date")]
    public DateTime? SessionDate { get; set; }

    [JsonProperty("session_name")]
    public string SessionName { get; set; }

    [JsonProperty("attendance_mark")]
    public string AttendanceMark { get; set; }

    [JsonProperty("minutes_late")]
    public int? MinutesLate { get; set; }

    [JsonProperty("comments")]
    public string Comments { get; set; }


    public Attendance()
    {
    }
  }
}
