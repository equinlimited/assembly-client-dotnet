using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class Facets : Resource
	{
		public Facets(ApiClient client)
			: base(client)
		{

		}


		public async Task<Facet> Facet(
		  int? id
		)
		{
		 	return default(Facet);
		}


		public async Task<FacetList> Facets(
		  int? perPage, 
		  int? page
		)
		{
		 	return default(FacetList);
		}

	}
}
