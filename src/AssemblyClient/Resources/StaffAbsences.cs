using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class StaffAbsencesResource : Resource
	{
		public StaffAbsencesResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// List Staff Absences
		/// </summary>
		/// <remarks>
		/// Returns a list of staff member absences for the school accociated with the provided &#x60;access_token&#x60;. A school level access token with the &#x60;staff_members.absences&#x60; scope is required to access staff member absence information.
		/// </remarks>
		/// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
		/// <param name="staffMemberId">show only absences fot the specified staff member (optional)</param>
		/// <param name="startDate">the start date of the period to query (optional)</param>
		/// <param name="qualifications">include HLTA status, QT status, QT route and previous degree information (requires &#x60;staff_members.qualifications&#x60; scope) (optional)</param>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;StaffAbsence&gt;</returns>
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
			var results = await Client.GetList<StaffAbsence>($"/staff_absences", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public StaffAbsencesResource StaffAbsences => new StaffAbsencesResource(this);
	}
}
