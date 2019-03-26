using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class BulkResultsBody
  {
    [JsonProperty("results")]
    public List<ResultEntry> Results { get; set; }


    public BulkResultsBody()
    {
      this.Results = new List<ResultEntry>();
    }
  }
}
