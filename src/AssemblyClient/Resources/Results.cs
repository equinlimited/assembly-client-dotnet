using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Results : Resource
	{
		public static string ResourceName => "";

		public Results(ApiClient client)
			: base(client)
		{

		}


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

			var results = await Client.GetList<Result>(ResourceName, args);

			return results;
		}

	}

	public partial class ApiClient
	{
		public Results Results => new Results(this);
	}
}
