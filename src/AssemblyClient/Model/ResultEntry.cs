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
  public class ResultEntry
  {
    [JsonProperty("student_id")]
    public int? StudentId { get; set; }

    [JsonProperty("grade_id")]
    public int? GradeId { get; set; }

    [JsonProperty("result_date")]
    public DateTime? ResultDate { get; set; }


    public ResultEntry()
    {
    }
  }
}
