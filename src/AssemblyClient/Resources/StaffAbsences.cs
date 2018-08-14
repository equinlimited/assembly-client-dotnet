using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class StaffAbsences : Resource
	{
		public StaffAbsences(ApiClient client)
			: base(client)
		{

		}


		public async Task<StaffAbsenceList> StaffAbscences(
		  int? staffMemberId, 
		  string startDate, 
		  string qualifications, 
		  DateTime? ifModifiedSince, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(StaffAbsenceList);
		}

	}
}
