using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class AcademicYearsResource : Resource
	{
		public AcademicYearsResource(ApiClient client)
			: base(client)
		{

		}

		public async Task<AcademicYear> Find(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();
			var result = await Client.GetObject<AcademicYear>($"/academic_years/{id}", args);
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
			var results = await Client.GetList<AcademicYear>("/academic_years", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public AcademicYearsResource AcademicYears => new AcademicYearsResource(this);
	}
}
