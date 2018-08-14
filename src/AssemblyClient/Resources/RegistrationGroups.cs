using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class RegistrationGroups : Resource
	{
		public RegistrationGroups(ApiClient client)
			: base(client)
		{

		}


		public async Task<RegistrationGroup> RegistrationGroup(
		  int? id, 
		  DateTime? date, 
		  int? academicYearId
		)
		{
		 	return default(RegistrationGroup);
		}


		public async Task<StudentList> RegistrationGroupStudents(
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


		public async Task<RegistrationGroup> RegistrationGroups(
		  DateTime? ifModifiedSince, 
		  int? yearCode, 
		  DateTime? date, 
		  int? academicYearId, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(RegistrationGroup);
		}

	}
}
