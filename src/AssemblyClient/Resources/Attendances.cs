using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Attendances : Resource
	{
		public Attendances(ApiClient client)
			: base(client)
		{

		}

		public async Task<List<Attendance>> List(
		  int? studentId = null, 
		  int? registrationGroupId = null, 
		  DateTime? startDate = null, 
		  DateTime? endDate = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.studentId = studentId;
			args.registrationGroupId = registrationGroupId;
			args.startDate = startDate;
			args.endDate = endDate;
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<Attendance>("/attendances", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public Attendances Attendances => new Attendances(this);
	}
}
