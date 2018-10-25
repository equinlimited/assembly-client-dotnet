using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class AcademicYearsResource : Resource
	{
		public AcademicYearsResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// View an Academic Year
		/// </summary>
		/// <remarks>
		/// Returns a single academic year for the school associated with the provided access_token.
		/// </remarks>
		/// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">id of the entity</param>
		/// <returns>AcademicYear</returns>
		public async Task<AcademicYear> Find(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();
			var result = await Client.GetObject<AcademicYear>($"/academic_years/{id}", args);
			return result;
		}

		/// <summary>
		/// List Academic Years
		/// </summary>
		/// <remarks>
		/// Returns a list of academic years for the school associated with the provided access_token. The dates of these academic years can be used to filter data in other API endpoints.
		/// </remarks>
		/// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;AcademicYear&gt;</returns>
		public async Task<List<AcademicYear>> List(
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<AcademicYear>($"/academic_years", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public AcademicYearsResource AcademicYears => new AcademicYearsResource(this);
	}
}
