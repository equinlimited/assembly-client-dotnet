using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Assessments : Resource
	{
		public static string ResourceName => "";

		public Assessments(ApiClient client)
			: base(client)
		{

		}


		public async Task<Assessment> Find(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();

			var resource = $"{ResourceName}/{id}";
			var result = await Client.GetObject<Assessment>(resource, args);

			return result;
		}


		public async Task<GradeSet> GradeSets(
		  int? id, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;

			var resource = $"{ResourceName}/{id}";
			var result = await Client.GetObject<GradeSet>(resource, args);

			return result;
		}


		public async Task<List<Assessment>> List(
		  int? misMappings = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.misMappings = misMappings;
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<Assessment>(ResourceName, args);

			return results;
		}


		public async Task<List<Result>> Results(
		  int? id, 
		  List<int?> students, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.students = students;
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<Result>(ResourceName, args);

			return results;
		}

	}

	public partial class ApiClient
	{
		public Assessments Assessments => new Assessments(this);
	}
}
