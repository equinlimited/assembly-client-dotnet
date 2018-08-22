using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class AssessmentPoints : Resource
	{
		public AssessmentPoints(ApiClient client)
			: base(client)
		{

		}

		public async Task<string> Find(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();
			var result = await Client.GetObject<string>($"/assessment_points/{id}", args);
			return result;
		}

		public async Task<List<string>> List(
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<string>("/assessment_points", args);
			return results;
		}

		public async Task<List<Result>> Results(
		  int? id, 
		  int? assessmentPointRank, 
		  List<int?> students
		)
		{
			dynamic args = new ExpandoObject();
			args.students = students;
			var results = await Client.GetList<Result>("/assessment_points/{id}/results", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public AssessmentPoints AssessmentPoints => new AssessmentPoints(this);
	}
}
