using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Net.Http;
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
		/// Update Multiple Results
		/// </summary>
		/// <remarks>
		/// Multiple results can be updated simultaneously by providing the relevant result_ids in the body of your request. The response will tell you whether the batch of updates has either been successful or failed.
		/// </remarks>
		/// <param name="bulkResultsBody"> (optional)</param>
		/// <returns>ApiResponse</returns>
		public async Task<ApiResponse> BulkUpdate(
		  BulkResultsBody bulkResultsBody = null
		)
		{
			var result = await Client.SendData<ApiResponse>(new HttpMethod("PATCH"), $"/results", bulkResultsBody);
			return result;
		}

		/// <summary>
		/// Write Results
		/// </summary>
		/// <remarks>
		/// Given a subject_id, facet_id, assessment_point_rank and assessment_id results can be sent to the Platform, along with a student_id, the grade_id and (optionally) the result_date.  **Permissions**: A school level access token with the assessments.write scope is needed to write results back to the Platform. 
		/// </remarks>
		/// <param name="resultBody"> (optional)</param>
		/// <returns>List&lt;Result&gt;</returns>
		public async Task<List<Result>> Create(
		  ResultBody resultBody = null
		)
		{
			var result = await Client.SendData<List<Result>>(new HttpMethod("POST"), $"/results", resultBody);
			return result;
		}

		/// <summary>
		/// List Results
		/// </summary>
		/// <remarks>
		/// Returns a list of results for the student ID(s) specified by the students parameter.
		/// </remarks>
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
			var results = await Client.GetList<List<Result>>($"/results", args);
			return results;
		}

		/// <summary>
		/// Update a Single Result
		/// </summary>
		/// <remarks>
		/// Once a result has been created, it can be updated on the Platform by passing the required field values in the request body. A list of the fields that were changed are returned in the response.
		/// </remarks>
		/// <param name="id">id of the entity</param>
		/// <param name="resultEntry"> (optional)</param>
		/// <returns>Result</returns>
		public async Task<Result> Update(
		  int? id, 
		  ResultEntry resultEntry = null
		)
		{
			var result = await Client.SendData<Result>(new HttpMethod("PATCH"), $"/results/{id}", resultEntry);
			return result;
		}

	}

	public partial class ApiClient
	{
		public ResultsResource Results => new ResultsResource(this);
	}
}
