using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class RegistrationGroupsResource : Resource
	{
		public RegistrationGroupsResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// View a Registration Group
		/// </summary>
		/// <remarks>
		/// Returns a list of registration groups that match the given set of filters.
		/// </remarks>
		/// <param name="id">id of the entity</param>
		/// <param name="date">returns results for a specific date (optional)</param>
		/// <param name="academicYearId">returns all groups and group memberships from the specified academic year (optional)</param>
		/// <returns>RegistrationGroup</returns>
		public async Task<RegistrationGroup> Find(
		  int? id, 
		  DateTime? date = null, 
		  int? academicYearId = null
		)
		{
			dynamic args = new ExpandoObject();
			args.date = date;
			args.academicYearId = academicYearId;
			var result = await Client.GetObject<RegistrationGroup>($"/registration_groups/{id}", args);
			return result;
		}

		/// <summary>
		/// List Registration Group
		/// </summary>
		/// <remarks>
		/// Returns a list of registration groups that match the given set of filters.  If a date parameter is provided then the list of groups returned is filtered to only those where the provided date falls between the groups start_date and end_date. Additionally when a date parameter is provided student_ids and supervior_ids are restricted to only those students who were enrolled in the group on the given date.  **Note:** Note the &#x60;If-Modified-Since&#x60; header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 
		/// </remarks>
		/// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
		/// <param name="yearCode">filter by school year (cannot be supplied at the same time as the students parameter) (optional)</param>
		/// <param name="date">returns results for a specific date (optional)</param>
		/// <param name="academicYearId">returns all groups and group memberships from the specified academic year (optional)</param>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;RegistrationGroup&gt;</returns>
		public async Task<List<RegistrationGroup>> List(
		  DateTime? ifModifiedSince = null, 
		  int? yearCode = null, 
		  DateTime? date = null, 
		  int? academicYearId = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.ifModifiedSince = ifModifiedSince;
			args.yearCode = yearCode;
			args.date = date;
			args.academicYearId = academicYearId;
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<List<RegistrationGroup>>($"/registration_groups", args);
			return results;
		}

		/// <summary>
		/// List Students for Registration Group
		/// </summary>
		/// <remarks>
		/// Returns a list of all the students that are present in the registration group identified by group_id.  **Note:** Note the &#x60;If-Modified-Since&#x60; header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 
		/// </remarks>
		/// <param name="id">id of the entity</param>
		/// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
		/// <param name="date">returns results for a specific date (optional)</param>
		/// <param name="academicYearId">returns all groups and group memberships from the specified academic year (optional)</param>
		/// <param name="demographics">include demographics data (optional)</param>
		/// <param name="contacts">include contacts data (optional)</param>
		/// <param name="senNeeds">include SEN needs data (optional)</param>
		/// <param name="addresses">include student address data (optional)</param>
		/// <param name="care">include student care data (you must also supply the demographics parameter) (optional)</param>
		/// <param name="everInCare">include whether the student has ever been in care (you must also supply the demographics parameter) (optional)</param>
		/// <param name="languages">include student language data (optional)</param>
		/// <param name="photo">include student photo data (optional)</param>
		/// <returns>List&lt;Student&gt;</returns>
		public async Task<List<Student>> Students(
		  int? id, 
		  DateTime? ifModifiedSince = null, 
		  DateTime? date = null, 
		  int? academicYearId = null, 
		  bool? demographics = null, 
		  bool? contacts = null, 
		  bool? senNeeds = null, 
		  bool? addresses = null, 
		  bool? care = null, 
		  bool? everInCare = null, 
		  bool? languages = null, 
		  bool? photo = null
		)
		{
			dynamic args = new ExpandoObject();
			args.ifModifiedSince = ifModifiedSince;
			args.date = date;
			args.academicYearId = academicYearId;
			args.demographics = demographics;
			args.contacts = contacts;
			args.senNeeds = senNeeds;
			args.addresses = addresses;
			args.care = care;
			args.everInCare = everInCare;
			args.languages = languages;
			args.photo = photo;
			var results = await Client.GetList<List<Student>>($"/registration_groups/{id}/students", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public RegistrationGroupsResource RegistrationGroups => new RegistrationGroupsResource(this);
	}
}
