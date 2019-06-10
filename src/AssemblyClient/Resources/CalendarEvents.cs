/**
 * Assembly Developer API .NET Client
 * SDK Version 2.2.363
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
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssemblyClient
{
  public class CalendarEventsResource : Resource
  {
    public CalendarEventsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// List Calendar Events
    /// </summary>
    /// <remarks>
    /// Returns a list of calendar events from the school calendar. We *strongly* recommend that you use an object type to filter the events that will be returned to you. Presently, with SIMS only support, we&#39;ve exposed the raw types from the underlying MIS. As such, it&#39;s most likely that you&#39;ll mostly be interested in &#39;User&#39; events. This category includes items such as staff meetings and school assembly times as you can see from the sample response below
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="eventType">Filter by a calendar object type from the underlying MIS (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;CalendarEvent&gt;</returns>
    public async Task<List<CalendarEvent>> List(
      DateTime? ifModifiedSince = null, 
      string eventType = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.eventType = eventType;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<CalendarEvent>($"/calendar_events", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public CalendarEventsResource CalendarEvents => new CalendarEventsResource(this);
  }
}
