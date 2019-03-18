using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class SchoolResource : Resource
	{
		public SchoolResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// Get School Details
		/// </summary>
		/// <remarks>
		/// Returns details for the school associated with the provided access_token.
		/// </remarks>
		/// <param name="id">id of the entity</param>
		/// <returns>School</returns>
		public async Task<School> Show(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();
			var result = await Client.GetObject<School>($"/school", args);
			return result;
		}

		/// <summary>
		/// Get School Sync Status
		/// </summary>
		/// <remarks>
		/// Returns status for the school associated with the provided access_token.
		/// </remarks>
		/// <returns>SchoolStatus</returns>
		public async Task<SchoolStatus> Status(
		)
		{
			dynamic args = new ExpandoObject();
			var result = await Client.GetObject<SchoolStatus>($"/school/status", args);
			return result;
		}

	}

	public partial class ApiClient
	{
		public SchoolResource School => new SchoolResource(this);
	}
}
