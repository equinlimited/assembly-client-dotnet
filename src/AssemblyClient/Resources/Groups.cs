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
  public class GroupsResource : Resource
  {
    public GroupsResource(ApiClient client)
      : base(client)
    {
    }

    /// <summary>
    /// View a Group
    /// </summary>
    /// <remarks>
    /// Returns a list of groups that match the given set of filters
    /// </remarks>
    /// <param name="id">Internal identifier of the entity</param>
    /// <returns>Group</returns>
    public async Task<Group> Find(
      int? id
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<Group>($"/groups/{id}", args);
      return result;
    }

    /// <summary>
    /// List Groups
    /// </summary>
    /// <remarks>
    /// Returns a list of groups that match the given set of filters.  If a date parameter is provided then the list of groups returned is filtered to only those where the provided date falls between the groups &#x60;start_date&#x60; and &#x60;end_date&#x60;. Additionally when a date parameter is provided &#x60;student_ids&#x60; and &#x60;supervior_ids&#x60; are restricted to only those students who were enrolled in the group on the given date. 
    /// </remarks>
    /// <param name="ifModifiedSince">Filter results since it was last fetched (see [Conditional Requests](/#section/Concepts/Conditional-Requests)) (optional)</param>
    /// <param name="academicYearId">Include all groups and group memberships from the specified academic year (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;Group&gt;</returns>
    public async Task<List<Group>> List(
      DateTime? ifModifiedSince = null, 
      int? academicYearId = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.academicYearId = academicYearId;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<Group>($"/groups", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public GroupsResource Groups => new GroupsResource(this);
  }
}
