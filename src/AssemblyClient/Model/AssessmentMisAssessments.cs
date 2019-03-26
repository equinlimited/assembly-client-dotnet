using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class AssessmentMisAssessments
  {
    [JsonProperty("type")]
    public string Type { get; set; }


    public AssessmentMisAssessments()
    {
    }
  }
}
