using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class RegistrationGroups : Resource
	{
		public RegistrationGroups(ApiClient client)
			: base(client)
		{

		}


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

			var results = await Client.GetList<RegistrationGroup>("/registration_groups", args);

			return results;
		}


		public async Task<List<Student>> Studens(
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

			var results = await Client.GetList<Student>("/registration_groups/{id}/students", args);

			return results;
		}

	}

	public partial class ApiClient
	{
		public RegistrationGroups RegistrationGroups => new RegistrationGroups(this);
	}
}