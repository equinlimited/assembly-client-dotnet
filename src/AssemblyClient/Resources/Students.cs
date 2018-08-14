using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Students : Resource
	{
		public Students(ApiClient client)
			: base(client)
		{

		}


		public async Task<StudentList> LeftStudents(
		  DateTime? ifModifiedSince, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(StudentList);
		}


		public async Task<Student> Student(
		  int? id, 
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
		 	return default(Student);
		}


		public async Task<StudentList> Students(
		  DateTime? ifModifiedSince, 
		  List<int?> students, 
		  DateTime? date, 
		  int? yearCode, 
		  bool? demographics, 
		  bool? contacts, 
		  bool? senNeeds, 
		  bool? addresses, 
		  bool? care, 
		  bool? everInCare, 
		  bool? languages, 
		  bool? photo, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(StudentList);
		}

	}
}
