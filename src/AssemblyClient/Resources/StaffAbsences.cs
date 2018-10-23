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

		public async Task<List<StaffAbsence>> List(
		  DateTime? ifModifiedSince = null, 
		  int? staffMemberId = null, 
		  DateTime? startDate = null, 
		  int? qualifications = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.ifModifiedSince = ifModifiedSince;
			args.staffMemberId = staffMemberId;
			args.startDate = startDate;
			args.qualifications = qualifications;
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<StaffAbsence>("/staff_absences", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public StaffAbsences StaffAbsences => new StaffAbsences(this);
	}
}
