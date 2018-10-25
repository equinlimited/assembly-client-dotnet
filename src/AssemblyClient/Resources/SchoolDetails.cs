using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class SchoolDetailsResource : Resource
	{
		public SchoolDetailsResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// List School Details
		/// </summary>
		/// <remarks>
		/// Returns details for the school associated with the provided access_token.
		/// </remarks>
		/// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>SchoolDetails</returns>
		public async Task<SchoolDetails> Show(
		)
		{
			dynamic args = new ExpandoObject();
			var result = await Client.GetObject<SchoolDetails>($"/school_details", args);
			return result;
		}

	}

	public partial class ApiClient
	{
		public SchoolDetailsResource SchoolDetails => new SchoolDetailsResource(this);
	}
}
