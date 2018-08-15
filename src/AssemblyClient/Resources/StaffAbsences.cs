using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class StaffAbsences : Resource
	{
		public static string ResourceName => "";

		public StaffAbsences(ApiClient client)
			: base(client)
		{

		}


		public async Task<List<StaffAbsence>> List(
		  int? staffMemberId = null, 
		  string startDate = null, 
		  string qualifications = null, 
		  DateTime? ifModifiedSince = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.staffMemberId = staffMemberId;
			args.startDate = startDate;
			args.qualifications = qualifications;
			args.ifModifiedSince = ifModifiedSince;
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<StaffAbsence>(ResourceName, args);

			return results;
		}

	}

	public partial class ApiClient
	{
		public StaffAbsences StaffAbsences => new StaffAbsences(this);
	}
}
