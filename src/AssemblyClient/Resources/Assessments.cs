using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Assessments : Resource
	{
		public Assessments(ApiClient client)
			: base(client)
		{

		}


		public async Task<AssessmentList> All(
		  int? misMappings, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(AssessmentList);
		}


		public async Task<Assessment> Find(
		  int? id
		)
		{
		 	return default(Assessment);
		}


		public async Task<GradeSet> GradeSets(
		  int? id, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(GradeSet);
		}


		public async Task<ResultList> Results(
		  int? id, 
		  List<int?> students, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(ResultList);
		}

	}
}
