using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class Exclusion
  {
    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("student_id")]
    public int? StudentId { get; set; }

    [JsonProperty("exclusion_type")]
    public string ExclusionType { get; set; }

    [JsonProperty("exclusion_reason")]
    public string ExclusionReason { get; set; }

    [JsonProperty("start_date")]
    public DateTime? StartDate { get; set; }

    [JsonProperty("start_session")]
    public string StartSession { get; set; }

    [JsonProperty("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonProperty("end_session")]
    public string EndSession { get; set; }

    [JsonProperty("exclusion_length")]
    public int? ExclusionLength { get; set; }


    public Exclusion()
    {
    }
  }
}
