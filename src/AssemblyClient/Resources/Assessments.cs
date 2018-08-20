using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Assessments : Resource
	{
		public Assessments(ApiClient client)
			: base(client)
		{

		}

		public async Task<GradeSet> GradeSet(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();

			var result = await Client.GetObject<GradeSet>($"/assessments/{id}/grade_set", args);

			return result;
		}

		public async Task<List<Assessment>> Index(
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<Assessment>("/assessments", args);

			return results;
		}

		public async Task<List<Result>> Results(
		  int? id, 
		  List<int?> students
		)
		{
			dynamic args = new ExpandoObject();
			args.students = students;

			var results = await Client.GetList<Result>("/assessments/{id}/results", args);

			return results;
		}

		public async Task<Assessment> Show(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();

			var result = await Client.GetObject<Assessment>($"/assessments/{id}", args);

			return result;
		}

	}

	public partial class ApiClient
	{
		public Assessments Assessments => new Assessments(this);
	}
}
