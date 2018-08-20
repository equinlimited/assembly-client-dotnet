using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class AcademicYears : Resource
	{
		public AcademicYears(ApiClient client)
			: base(client)
		{

		}

		public async Task<List<AcademicYear>> Index(
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

		public async Task<AcademicYear> Show(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();

			var result = await Client.GetObject<AcademicYear>($"/academic_years/{id}", args);

			return result;
		}

	}

	public partial class ApiClient
	{
		public AcademicYears AcademicYears => new AcademicYears(this);
	}
}
