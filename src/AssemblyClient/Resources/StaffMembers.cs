using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class StaffMembersResource : Resource
	{
		public StaffMembersResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// View a Staff Member
		/// </summary>
		/// <remarks>
		/// Returns an individual staff member record for the given ID.  **Note:** Note the &#x60;If-Modified-Since&#x60; header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 
		/// </remarks>
		/// <param name="id">id of the entity</param>
		/// <param name="demographics">include demographics data (optional)</param>
		/// <param name="qualifications">include HLTA status, QT status, QT route and previous degree information (requires &#x60;staff_members.qualifications&#x60; scope) (optional)</param>
		/// <returns>StaffMember</returns>
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

		/// <summary>
		/// List Left Staff Members
		/// </summary>
		/// <remarks>
		/// Returns a list of staff members who have left the school.  **Note:** The &#x60;If-Modified-Since&#x60; header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details).&#39; 
		/// </remarks>
		/// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
		/// <param name="teachersOnly">return only staff who are teachers (optional)</param>
		/// <param name="demographics">include demographics data (optional)</param>
		/// <param name="qualifications">include HLTA status, QT status, QT route and previous degree information (requires &#x60;staff_members.qualifications&#x60; scope) (optional)</param>
		/// <returns>List&lt;StaffMember&gt;</returns>
		public async Task<List<StaffMember>> Left(
		  DateTime? ifModifiedSince = null, 
		  bool? teachersOnly = null, 
		  bool? demographics = null, 
		  bool? qualifications = null
		)
		{
			dynamic args = new ExpandoObject();
			args.ifModifiedSince = ifModifiedSince;
			args.teachersOnly = teachersOnly;
			args.demographics = demographics;
			args.qualifications = qualifications;
			var results = await Client.GetList<List<StaffMember>>($"/staff_members/left", args);
			return results;
		}

		/// <summary>
		/// List Staff Members
		/// </summary>
		/// <remarks>
		/// Returns a list of staff members for the school accociated with the provided &#x60;access_token&#x60;.  **Note:** Note the &#x60;If-Modified-Since&#x60; header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 
		/// </remarks>
		/// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
		/// <param name="teachersOnly">return only staff who are teachers (optional)</param>
		/// <param name="demographics">include demographics data (optional)</param>
		/// <param name="qualifications">include HLTA status, QT status, QT route and previous degree information (requires &#x60;staff_members.qualifications&#x60; scope) (optional)</param>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;StaffMember&gt;</returns>
		public async Task<List<StaffMember>> List(
		  DateTime? ifModifiedSince = null, 
		  bool? teachersOnly = null, 
		  bool? demographics = null, 
		  bool? qualifications = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.ifModifiedSince = ifModifiedSince;
			args.teachersOnly = teachersOnly;
			args.demographics = demographics;
			args.qualifications = qualifications;
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<List<StaffMember>>($"/staff_members", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public StaffMembersResource StaffMembers => new StaffMembersResource(this);
	}
}
