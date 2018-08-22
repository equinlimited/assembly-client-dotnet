using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Exclusions : Resource
	{
		public Exclusions(ApiClient client)
			: base(client)
		{

		}

		public async Task<List<Exclusion>> List(
		  int? studentId = null, 
		  string startDate = null, 
		  string qualifications = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.studentId = studentId;
			args.startDate = startDate;
			args.qualifications = qualifications;
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<Exclusion>("/exclusions", args);

			return results;
		}

	}

	public partial class ApiClient
	{
		public Exclusions Exclusions => new Exclusions(this);
	}
}
