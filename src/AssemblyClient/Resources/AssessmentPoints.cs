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

		public async Task<AssessmentPoint> Find(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();
			var result = await Client.GetObject<AssessmentPoint>($"/assessment_points/{id}", args);
			return result;
		}

		public async Task<List<AssessmentPoint>> List(
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<AssessmentPoint>("/assessment_points", args);
			return results;
		}

		public async Task<List<Result>> Results(
		  int? id, 
		  List<int?> students, 
		  int? assessmentPointRank = null
		)
		{
			dynamic args = new ExpandoObject();
			args.students = students;
			args.assessmentPointRank = assessmentPointRank;
			var results = await Client.GetList<Result>("/assessment_points/{id}/results", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public AssessmentPoints AssessmentPoints => new AssessmentPoints(this);
	}
}
