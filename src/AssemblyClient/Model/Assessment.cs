using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class Assessment
  {
    [JsonProperty("family_id")]
    public int? FamilyId { get; set; }

    [JsonProperty("family_name")]
    public string FamilyName { get; set; }

    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("mis_assessments")]
    public List<AssessmentMisAssessments> MisAssessments { get; set; }


    public Assessment()
    {
      this.MisAssessments = new List<AssessmentMisAssessments>();
    }
  }
}
