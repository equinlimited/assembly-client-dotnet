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


		public async Task<AcademicYear> All(
		  int? id
		)
		{
		 	return default(AcademicYear);
		}


		public async Task<AcademicYearList> List(
		  int? perPage, 
		  int? page
		)
		{
		 	return default(AcademicYearList);
		}

	}
}
