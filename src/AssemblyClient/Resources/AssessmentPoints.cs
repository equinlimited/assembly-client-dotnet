using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class AssessmentPointsResource : Resource
	{
		public AssessmentPointsResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// View an Assessment Point
		/// </summary>
		/// <remarks>
		/// Returns a single assessment point for the given rank.
		/// </remarks>
		/// <param name="id">id of the entity</param>
		/// <returns>AssessmentPoint</returns>
		public async Task<AssessmentPoint> Find(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();
			var result = await Client.GetObject<AssessmentPoint>($"/assessment_points/{id}", args);
			return result;
		}

		/// <summary>
		/// List Assessment Points
		/// </summary>
		/// <remarks>
		/// Returns a list of assessment points. An assessment_point object represents a point in the school key stage, year, term or half-term that results can be attached to. When sending results back to the Platform, the assessment_point_rank should be used - this will remain constant across all environments.
		/// </remarks>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;AssessmentPoint&gt;</returns>
		public async Task<List<AssessmentPoint>> List(
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<AssessmentPoint>($"/assessment_points", args);
			return results;
		}

		/// <summary>
		/// View Results for an Assessment Point
		/// </summary>
		/// <remarks>
		/// Returns a list of results for the given assessment_point_rank and students.
		/// </remarks>
		/// <param name="id">id of the entity</param>
		/// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded).</param>
		/// <param name="assessmentPointRank">the Assessment Point rank (optional)</param>
		/// <returns>List&lt;Result&gt;</returns>
		public async Task<List<Result>> Results(
		  int? id, 
		  List<int?> students, 
		  int? assessmentPointRank = null
		)
		{
			dynamic args = new ExpandoObject();
			args.students = students;
			args.assessmentPointRank = assessmentPointRank;
			var results = await Client.GetList<Result>($"/assessment_points/{id}/results", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public AssessmentPointsResource AssessmentPoints => new AssessmentPointsResource(this);
	}
}
