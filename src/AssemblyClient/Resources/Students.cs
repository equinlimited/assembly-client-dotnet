using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Students : Resource
	{
		public static string ResourceName => "";

		public Students(ApiClient client)
			: base(client)
		{

		}


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

			var resource = $"{ResourceName}/{id}";
			var result = await Client.GetObject<Student>(resource, args);

			return result;
		}


		public async Task<List<Student>> Left(
		  DateTime? ifModifiedSince = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.ifModifiedSince = ifModifiedSince;
			args.perPage = perPage;
			args.page = page;

			var results = await Client.GetList<Student>(ResourceName, args);

			return results;
		}


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

			var results = await Client.GetList<Student>(ResourceName, args);

			return results;
		}

	}

	public partial class ApiClient
	{
		public Students Students => new Students(this);
	}
}
