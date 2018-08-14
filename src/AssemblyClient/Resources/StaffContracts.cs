using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class StaffContracts : Resource
	{
		public StaffContracts(ApiClient client)
			: base(client)
		{

		}


		public async Task<StaffMemberList> StaffContracts(
		  int? staffMemberId, 
		  bool? date, 
		  bool? roles, 
		  bool? salaries, 
		  bool? allowances, 
		  DateTime? ifModifiedSince, 
		  int? perPage, 
		  int? page
		)
		{
		 	return default(StaffMemberList);
		}

	}
}
