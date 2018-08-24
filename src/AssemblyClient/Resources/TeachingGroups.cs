using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class TeachingGroups : Resource
	{
		public TeachingGroups(ApiClient client)
			: base(client)
		{

		}

		public async Task<TeachingGroup> Find(
		  int? id, 
		  DateTime? date = null, 
		  DateTime? academicYearId = null, 
		  DateTime? groupId = null
		)
		{
			dynamic args = new ExpandoObject();
			args.date = date;
			args.academicYearId = academicYearId;
			args.groupId = groupId;
			var result = await Client.GetObject<TeachingGroup>($"/teaching_groups/{id}", args);
			return result;
		}

		public async Task<List<TeachingGroup>> List(
		  DateTime? subjectCode = null, 
		  DateTime? yearCode = null, 
		  DateTime? date = null, 
		  DateTime? academicYearId = null, 
		  DateTime? ifModifiedSince = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.subjectCode = subjectCode;
			args.yearCode = yearCode;
			args.date = date;
			args.academicYearId = academicYearId;
			args.ifModifiedSince = ifModifiedSince;
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<TeachingGroup>("/teaching_groups", args);
			return results;
		}

		public async Task<List<Student>> Students(
		  int? id, 
		  DateTime? ifModifiedSince = null, 
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
			args.demographics = demographics;
			args.contacts = contacts;
			args.senNeeds = senNeeds;
			args.addresses = addresses;
			args.care = care;
			args.everInCare = everInCare;
			args.languages = languages;
			args.photo = photo;
			var results = await Client.GetList<Student>("/teaching_groups/{id}/students", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public TeachingGroups TeachingGroups => new TeachingGroups(this);
	}
}
