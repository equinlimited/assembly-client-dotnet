using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class SenNeed
  {
    [JsonProperty("id")]
    public int? Id { get; set; }

    [JsonProperty("start_date")]
    public string StartDate { get; set; }

    [JsonProperty("sen_need_code")]
    public string SenNeedCode { get; set; }

    [JsonProperty("sen_need_name")]
    public string SenNeedName { get; set; }

    [JsonProperty("sen_broad_need_type_code")]
    public string SenBroadNeedTypeCode { get; set; }

    [JsonProperty("sen_broad_need_type_name")]
    public string SenBroadNeedTypeName { get; set; }

    [JsonProperty("priority")]
    public int? Priority { get; set; }


    public SenNeed()
    {
    }
  }
}
