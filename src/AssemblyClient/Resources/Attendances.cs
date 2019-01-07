using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class AttendancesResource : Resource
	{
		public AttendancesResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// List Attendances
		/// </summary>
		/// <remarks>
		/// Returns a list of attendances. By default, attendances are returned from the start to the end of the current week.  **Note:** Note the &#x60;If-Modified-Since&#x60; header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 
		/// </remarks>
		/// <param name="studentId">a student_id to filter by (optional)</param>
		/// <param name="registrationGroupId">id of a registration group (optional)</param>
		/// <param name="startDate">the start date of the period to query (optional)</param>
		/// <param name="endDate">the end date of the period to query (optional)</param>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;Attendance&gt;</returns>
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
			var results = await Client.GetList<Attendance>($"/attendances", args);
			return results;
		}

		/// <summary>
		/// List Attendance Summaries
		/// </summary>
		/// <remarks>
		/// Returns a list of attendance summaries.  **Note:** Note the &#x60;If-Modified-Since&#x60; header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 
		/// </remarks>
		/// <param name="studentId">a student_id to filter by (optional)</param>
		/// <param name="registrationGroupId">id of a registration group (optional)</param>
		/// <returns>List&lt;AttendanceSummary&gt;</returns>
		public async Task<List<AttendanceSummary>> List_0(
		  int? studentId = null, 
		  int? registrationGroupId = null
		)
		{
			dynamic args = new ExpandoObject();
			args.studentId = studentId;
			args.registrationGroupId = registrationGroupId;
			var results = await Client.GetList<AttendanceSummary>($"/attendances/summaries", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public AttendancesResource Attendances => new AttendancesResource(this);
	}
}
