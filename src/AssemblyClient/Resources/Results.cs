using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Results : Resource
	{
		public Results(ApiClient client)
			: base(client)
		{

		}


		public async Task<ResultList> Results(
		  List<int?> students, 
		  DateTime? ifModifiedSince, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(ResultList);
		}

	}
}
