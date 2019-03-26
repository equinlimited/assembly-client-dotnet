using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class StudentAddress
  {
    [JsonProperty("address_line_1")]
    public string AddressLine1 { get; set; }

    [JsonProperty("address_line_2")]
    public string AddressLine2 { get; set; }

    [JsonProperty("town_city")]
    public string TownCity { get; set; }

    [JsonProperty("county")]
    public string County { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("postcode")]
    public string Postcode { get; set; }


    public StudentAddress()
    {
    }
  }
}
