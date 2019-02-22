using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class MedicalConditionsResource : Resource
	{
		public MedicalConditionsResource(ApiClient client)
			: base(client)
		{

		}

		/// <summary>
		/// View an Medical Condition
		/// </summary>
		/// <remarks>
		/// Returns a single medical condition for the given id.
		/// </remarks>
		/// <param name="id">id of the entity</param>
		/// <returns>MedicalCondition</returns>
		public async Task<MedicalCondition> Find(
		  int? id
		)
		{
			dynamic args = new ExpandoObject();
			var result = await Client.GetObject<MedicalCondition>($"/school/medical_conditions/{id}", args);
			return result;
		}

		/// <summary>
		/// Medical Conditions
		/// </summary>
		/// <remarks>
		/// Returns a list of all the Medical Conditions defined by the school.
		/// </remarks>
		/// <param name="perPage">Number of results to return (optional, default to 100)</param>
		/// <param name="page">Page number to return (optional, default to 1)</param>
		/// <returns>List&lt;MedicalCondition&gt;</returns>
		public async Task<List<MedicalCondition>> List(
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<List<MedicalCondition>>($"/school/medical_conditions", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public MedicalConditionsResource MedicalConditions => new MedicalConditionsResource(this);
	}
}
