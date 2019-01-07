using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class GradeSetsResource : Resource
	{
		public GradeSetsResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// View a Grade Set
		/// </summary>
		/// <remarks>
		/// Returns a single grade set for the given id.
		/// </remarks>
		/// <param name="id">id of the entity</param>
		/// <returns>GradeSet</returns>
		public async Task<GradeSet> Find(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();
			var result = await Client.GetObject<GradeSet>($"/grade_sets/{id}", args);
			return result;
		}

		/// <summary>
		/// List Grade Sets
		/// </summary>
		/// <remarks>
		/// Returns a list of grade sets.
		/// </remarks>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;GradeSet&gt;</returns>
		public async Task<List<GradeSet>> List(
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<GradeSet>($"/grade_sets", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public GradeSetsResource GradeSets => new GradeSetsResource(this);
	}
}
