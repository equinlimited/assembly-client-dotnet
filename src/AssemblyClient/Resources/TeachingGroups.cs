using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class TeachingGroups : Resource
	{
		public TeachingGroups(ApiClient client)
			: base(client)
		{

		}


		public async Task<TeachingGroup> TeachingGroup(
		  int? id, 
		  DateTime? date, 
		  int? academicYearId, 
		  int? groupId
		)
		{
		 	return default(TeachingGroup);
		}


		public async Task<StudentList> TeachingGroupStudents(
		  int? id, 
		  DateTime? ifModifiedSince, 
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


		public async Task<TeachingGroupList> TeachingGroups(
		  string subjectCode, 
		  int? yearCode, 
		  DateTime? date, 
		  int? academicYearId, 
		  DateTime? ifModifiedSince, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(TeachingGroupList);
		}

	}
}
