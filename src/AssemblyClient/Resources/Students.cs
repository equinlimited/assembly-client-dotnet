using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class StudentsResource : Resource
	{
		public StudentsResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// View a Student
		/// </summary>
		/// <remarks>
		/// Returns an individual student record for the given ID.  **Note:** the response shown includes student demographics, contacts, student SEN needs, student addresses, photo and student care data but these will only be present if you have permission to access it and pass &#x60;demographics&#x60;, &#x60;contacts&#x60;, &#x60;sen_needs&#x60;, &#x60;addresses&#x60;, &#x60;photo&#x60;, &#x60;care&#x60; and &#x60;ever_in_care&#x60; respectively  **Note:** Note the &#x60;If-Modified-Since&#x60; header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details).  ### Photo Notes When requesting photo information the response includes a &#x60;photo.url&#x60; property, this URL should be treated as confidential and used to download the students photo to your storage system of choice. The URL is *not designed for hotlinking directly in the browser* for end users. URLs are signed and only valid for 1 hour after which time you will receive a 400 error.  Once downloaded to avoid repeatedly syncing unchanged photos you should code your application to compare the &#x60;photo.hash&#x60; property to detect changes in student photos since your last sync, it is guaranteed that changes in a photo will change the hash, however the hash is only intended to be used to detect photo changes and is not guaranteed to match a checksum of the files contents.  Photos are currently provided on an \&quot;as is\&quot; basis straight from the source MIS, this means the format, quality, metadata and dimensions are not guaranteed. We reserve the right to normalise this data in the future but your application should be resistant to differing photo formats. 
		/// </remarks>
		/// <param name="id">id of the entity</param>
		/// <param name="demographics">include demographics data (optional)</param>
		/// <param name="contacts">include contacts data (optional)</param>
		/// <param name="senNeeds">include SEN needs data (optional)</param>
		/// <param name="addresses">include student address data (optional)</param>
		/// <param name="care">include student care data (you must also supply the demographics parameter) (optional)</param>
		/// <param name="everInCare">include whether the student has ever been in care (you must also supply the demographics parameter) (optional)</param>
		/// <param name="languages">include student language data (optional)</param>
		/// <param name="photo">include student photo data (optional)</param>
		/// <returns>Student</returns>
		public async Task<Student> Find(
		  int? id, 
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
			args.demographics = demographics;
			args.contacts = contacts;
			args.senNeeds = senNeeds;
			args.addresses = addresses;
			args.care = care;
			args.everInCare = everInCare;
			args.languages = languages;
			args.photo = photo;
			var result = await Client.GetObject<Student>($"/students/{id}", args);
			return result;
		}

		/// <summary>
		/// List Left Students
		/// </summary>
		/// <remarks>
		/// &#39;Returns a list of students who have left the school.  **Note:** Note the &#x60;If-Modified-Since&#x60; header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details).&#39; 
		/// </remarks>
		/// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
		/// <returns>List&lt;Student&gt;</returns>
		public async Task<List<Student>> Left(
		  DateTime? ifModifiedSince = null
		)
		{
			dynamic args = new ExpandoObject();
			args.ifModifiedSince = ifModifiedSince;
			var results = await Client.GetList<Student>($"/students/left", args);
			return results;
		}

		/// <summary>
		/// List Students
		/// </summary>
		/// <remarks>
		/// Returns a list of students for the school associated with the provided &#x60;access_token.&#x60; **Note:** the &#x60;If-Modified-Since&#x60; header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 
		/// </remarks>
		/// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
		/// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded). (optional)</param>
		/// <param name="date">returns results for a specific date (optional)</param>
		/// <param name="yearCode">filter by school year (cannot be supplied at the same time as the students parameter) (optional)</param>
		/// <param name="demographics">include demographics data (optional)</param>
		/// <param name="contacts">include contacts data (optional)</param>
		/// <param name="senNeeds">include SEN needs data (optional)</param>
		/// <param name="addresses">include student address data (optional)</param>
		/// <param name="care">include student care data (you must also supply the demographics parameter) (optional)</param>
		/// <param name="everInCare">include whether the student has ever been in care (you must also supply the demographics parameter) (optional)</param>
		/// <param name="languages">include student language data (optional)</param>
		/// <param name="photo">include student photo data (optional)</param>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;Student&gt;</returns>
		public async Task<List<Student>> List(
		  DateTime? ifModifiedSince = null, 
		  List<int?> students = null, 
		  DateTime? date = null, 
		  int? yearCode = null, 
		  bool? demographics = null, 
		  bool? contacts = null, 
		  bool? senNeeds = null, 
		  bool? addresses = null, 
		  bool? care = null, 
		  bool? everInCare = null, 
		  bool? languages = null, 
		  bool? photo = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.ifModifiedSince = ifModifiedSince;
			args.students = students;
			args.date = date;
			args.yearCode = yearCode;
			args.demographics = demographics;
			args.contacts = contacts;
			args.senNeeds = senNeeds;
			args.addresses = addresses;
			args.care = care;
			args.everInCare = everInCare;
			args.languages = languages;
			args.photo = photo;
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<Student>($"/students", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public StudentsResource Students => new StudentsResource(this);
	}
}
