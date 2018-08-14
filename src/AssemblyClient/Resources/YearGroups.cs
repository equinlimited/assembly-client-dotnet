using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class YearGroups : Resource
	{
		public YearGroups(ApiClient client)
			: base(client)
		{

		}


		public async Task<YearGroup> YearGroup(
		  int? id, 
		  DateTime? date, 
		  int? academicYearId
		)
		{
		 	return default(YearGroup);
		}


		public async Task<StudentList> YearGroupStudents(
		  int? id, 
		  DateTime? ifModifiedSince, 
		  DateTime? date, 
		  int? academicYearId, 
		  bool? demographics, 
		  bool? contacts, 
		  bool? senNeeds, 
		  bool? addresses, 
		  bool? care, 
		  bool? everInCare, 
		  bool? languages, 
		  bool? photo
		)
		{
		 	return default(StudentList);
		}


		public async Task<YearGroup> YearGroups(
		  DateTime? ifModifiedSince, 
		  int? yearCode, 
		  DateTime? date, 
		  int? academicYearId, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(YearGroup);
		}

	}
}
