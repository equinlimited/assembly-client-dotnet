using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class ContactsResource : Resource
	{
		public ContactsResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// List Contacts
		/// </summary>
		/// <remarks>
		/// Returns a list of contacts that match the given set of filters.
		/// </remarks>
		/// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="studentId">a student_id to filter by (optional)</param>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;Contact&gt;</returns>
		public async Task<List<Contact>> List(
		  int? studentId = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.studentId = studentId;
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<Contact>($"/contacts", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public ContactsResource Contacts => new ContactsResource(this);
	}
}
