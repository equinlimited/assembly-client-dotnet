using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class SchoolDetails : Resource
	{
		public SchoolDetails(ApiClient client)
			: base(client)
		{

		}

		public async Task<School> Show(
		)
		{
			dynamic args = new ExpandoObject();

			var result = await Client.GetObject<School>($"/school_details", args);

			return result;
		}

	}

	public partial class ApiClient
	{
		public SchoolDetails SchoolDetails => new SchoolDetails(this);
	}
}
