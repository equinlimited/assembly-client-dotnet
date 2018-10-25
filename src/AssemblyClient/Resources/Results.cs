using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class ResultsResource : Resource
	{
		public ResultsResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// List Results
		/// </summary>
		/// <remarks>
		/// Returns a list of results for the student ID(s) specified by the students parameter.
		/// </remarks>
		/// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded).</param>
		/// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;Result&gt;</returns>
		public async Task<List<Result>> List(
		  List<int?> students, 
		  DateTime? ifModifiedSince = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.students = students;
			args.ifModifiedSince = ifModifiedSince;
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<Result>($"/results", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public ResultsResource Results => new ResultsResource(this);
	}
}
