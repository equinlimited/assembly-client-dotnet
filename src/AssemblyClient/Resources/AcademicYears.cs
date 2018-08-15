using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class AcademicYears : Resource
	{
		public static string ResourceName => "";

		public AcademicYears(ApiClient client)
			: base(client)
		{

		}


		public async Task<AcademicYear> Find(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();

			var resource = $"{ResourceName}/{id}";
			var result = await Client.GetObject<AcademicYear>(resource, args);

			return result;
		}


		public async Task<List<AcademicYear>> List(
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<AcademicYear>(ResourceName, args);

			return results;
		}

	}

	public partial class ApiClient
	{
		public AcademicYears AcademicYears => new AcademicYears(this);
	}
}
