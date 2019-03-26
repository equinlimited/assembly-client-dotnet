using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssemblyClient
{
  public class DietaryNeedsResource : Resource
  {
    public DietaryNeedsResource(ApiClient client)
      : base(client)
    {

    }

    /// <summary>
    /// View an Dietary Need
    /// </summary>
    /// <remarks>
    /// Returns a single dietary need for the given id.
    /// </remarks>
    /// <param name="id">id of the entity</param>
    /// <returns>DietaryNeed</returns>
    public async Task<DietaryNeed> Find(
      int? id
    )
    {
      dynamic args = new ExpandoObject();
      var result = await Client.GetObject<DietaryNeed>($"/school/dietary_needs/{id}", args);
      return result;
    }

    /// <summary>
    /// Dietary Needs
    /// </summary>
    /// <remarks>
    /// Returns a list of all the Dietary Needs defined by the school.
    /// </remarks>
    /// <param name="perPage">Number of results to return (optional, default to 100)</param>
    /// <param name="page">Page number to return (optional, default to 1)</param>
    /// <returns>List&lt;DietaryNeed&gt;</returns>
    public async Task<List<DietaryNeed>> List(
      int? perPage = null, 
      int? page = null
    )
    {
      dynamic args = new ExpandoObject();
      args.perPage = perPage;
      args.page = page;
      var results = await Client.GetList<DietaryNeed>($"/school/dietary_needs", args);
      return results;
    }

  }

  public partial class ApiClient
  {
    public DietaryNeedsResource DietaryNeeds => new DietaryNeedsResource(this);
  }
}
