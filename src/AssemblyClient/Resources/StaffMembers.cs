using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class StaffMembers : Resource
	{
		public StaffMembers(ApiClient client)
			: base(client)
		{

		}


		public async Task<StaffMember> StaffMember(
		  int? id, 
		  bool? demographics, 
		  bool? qualifications
		)
		{
		 	return default(StaffMember);
		}


		public async Task<StaffMemberList> StaffMembers(
		  bool? teachersOnly, 
		  bool? demographics, 
		  bool? qualifications, 
		  DateTime? ifModifiedSince, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(StaffMemberList);
		}

	}
}
