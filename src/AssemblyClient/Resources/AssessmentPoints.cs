using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class AssessmentPoints : Resource
	{
		public AssessmentPoints(ApiClient client)
			: base(client)
		{

		}


		public async Task<AssessmentPointList> All(
		  int? perPage, 
		  int? page
		)
		{
		 	return default(AssessmentPointList);
		}


		public async Task<string> Find(
		  int? id
		)
		{
		 	return default(string);
		}


		public async Task<ResultList> Results(
		  int? id, 
		  int? assessmentPointRank, 
		  List<int?> students, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(ResultList);
		}

	}
}
