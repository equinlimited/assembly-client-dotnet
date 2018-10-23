using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class ExclusionsResource : Resource
	{
		public ExclusionsResource(ApiClient client)
			: base(client)
		{

		}

		public async Task<List<Exclusion>> List(
		  int? studentId = null, 
		  DateTime? startDate = null, 
		  DateTime? endDate = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.studentId = studentId;
			args.startDate = startDate;
			args.endDate = endDate;
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<Exclusion>("/exclusions", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public ExclusionsResource Exclusions => new ExclusionsResource(this);
	}
}
