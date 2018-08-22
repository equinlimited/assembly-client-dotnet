using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class CalendarEvents : Resource
	{
		public CalendarEvents(ApiClient client)
			: base(client)
		{

		}

		public async Task<List<CalendarEvent>> List(
		  string eventType = null, 
		  int? perPage = null, 
		  int? page = null
		)
		{
			dynamic args = new ExpandoObject();
			args.eventType = eventType;
			args.perPage = perPage;
			args.page = page;
			var results = await Client.GetList<CalendarEvent>("/calendar_events", args);
			return results;
		}

	}

	public partial class ApiClient
	{
		public CalendarEvents CalendarEvents => new CalendarEvents(this);
	}
}
