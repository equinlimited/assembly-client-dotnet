using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class StaffContractsResource : Resource
	{
		public StaffContractsResource(ApiClient client)
			: base(client)
		{

		}

		public async Task<List<StaffContract>> List(
		  DateTime? ifModifiedSince = null, 
		  int? staffMemberId = null, 
		  bool? date = null, 
		  bool? roles = null, 
		  bool? salaries = null, 
		  bool? allowances = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.ifModifiedSince = ifModifiedSince;
			args.staffMemberId = staffMemberId;
			args.date = date;
			args.roles = roles;
			args.salaries = salaries;
			args.allowances = allowances;
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<StaffContract>("/staff_contracts", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public StaffContractsResource StaffContracts => new StaffContractsResource(this);
	}
}
