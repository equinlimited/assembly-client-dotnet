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


		public async Task<StaffMember> Find(
		  int? id, 
		  bool? demographics = null, 
		  bool? qualifications = null
		)
		{
			dynamic args = new ExpandoObject();
			args.demographics = demographics;
			args.qualifications = qualifications;

			var result = await Client.GetObject<StaffMember>($"/staff_members/{id}", args);

			return result;
		}


		public async Task<List<StaffMember>> List(
		  bool? teachersOnly = null, 
		  bool? demographics = null, 
		  bool? qualifications = null, 
		  DateTime? ifModifiedSince = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.teachersOnly = teachersOnly;
			args.demographics = demographics;
			args.qualifications = qualifications;
			args.ifModifiedSince = ifModifiedSince;
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<StaffMember>("/staff_members", args);

			return results;
		}

	}

	public partial class ApiClient
	{
		public StaffMembers StaffMembers => new StaffMembers(this);
	}
}
