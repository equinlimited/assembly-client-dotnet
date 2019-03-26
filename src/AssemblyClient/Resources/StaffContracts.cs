using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssemblyClient
{
  public class StaffContractsResource : Resource
  {
    public StaffContractsResource(ApiClient client)
      : base(client)
    {

    }

    /// <summary>
    /// List Staff Contracts
    /// </summary>
    /// <remarks>
    /// Returns a list of staff member contracts for the school accociated with the provided &#x60;access_token&#x60;. A school level access token with the &#x60;staff_members.contracts&#x60; scope is required to access staff member contract information.
    /// </remarks>
    /// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
    /// <param name="staffMemberId">show only absences fot the specified staff member (optional)</param>
    /// <param name="date">returns results for a specific date (optional)</param>
    /// <param name="roles">return roles information along with a staff contract (optional)</param>
    /// <param name="salaries">return salaries information along with a staff contract (requires staff_members.salaries scope for full information - only the hours_per_week, fte and weeks_per_year fields are shown without it) (optional)</param>
    /// <param name="allowances">return allowances information along with a staff contract (requires staff_members.salaries scope) (optional)</param>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;StaffContract&gt;</returns>
    public async Task<List<StaffContract>> List(
      DateTime? ifModifiedSince = null, 
      int? staffMemberId = null, 
      bool? date = null, 
      bool? roles = null, 
      bool? salaries = null, 
      bool? allowances = null, 
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.ifModifiedSince = ifModifiedSince;
      args.staffMemberId = staffMemberId;
      args.date = date;
      args.roles = roles;
      args.salaries = salaries;
      args.allowances = allowances;
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<StaffContract>($"/staff_contracts", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public StaffContractsResource StaffContracts => new StaffContractsResource(this);
  }
}
