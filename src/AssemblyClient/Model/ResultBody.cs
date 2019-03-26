using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class ResultBody
  {
    [JsonProperty("subject_id")]
    public int? SubjectId { get; set; }

    [JsonProperty("facet_id")]
    public int? FacetId { get; set; }

    [JsonProperty("assessment_point_rank")]
    public int? AssessmentPointRank { get; set; }

    [JsonProperty("assessment_id")]
    public int? AssessmentId { get; set; }

    [JsonProperty("results")]
    public List<ResultEntry> Results { get; set; }


    public ResultBody()
    {
      this.Results = new List<ResultEntry>();
    }
  }
}
