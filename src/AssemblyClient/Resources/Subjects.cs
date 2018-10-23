using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class SubjectsResource : Resource
	{
		public SubjectsResource(ApiClient client)
			: base(client)
		{

		}

		public async Task<List<Subject>> List(
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<Subject>("/subjects", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public SubjectsResource Subjects => new SubjectsResource(this);
	}
}
