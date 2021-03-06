/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.475
 * API Version 1.1.0
 *
 * Support
 * Email: help@assembly.education
 * URL:   http://developers.assembly.education
 *
 * Terms of Service: http://assembly.education/terms/
 * License:          MIT, https://spdx.org/licenses/MIT.html
 */


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AssemblyClient {
  public class LearningAim
  {
    [JsonProperty("object")]
    public string Object { get; set; }

    [JsonProperty("qualification_name")]
    public string QualificationName { get; set; }

    [JsonProperty("qualification_number")]
    public string QualificationNumber { get; set; }

    [JsonProperty("discount_code")]
    public string DiscountCode { get; set; }

    [JsonProperty("qan_subject")]
    public string QanSubject { get; set; }

    [JsonProperty("expiry_date")]
    public DateTime? ExpiryDate { get; set; }


    public LearningAim()
    {
    }
  }
}
