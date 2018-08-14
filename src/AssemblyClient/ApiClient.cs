using System;
using System.Net.Http;
using System.Dynamic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssemblyClient
{
	public class ApiClient
	{
		private readonly Api api;

		public ApiConfiguration Configuration => this.api.Configuration;

		public event EventHandler<TokenRefreshedEventArgs> TokenRefreshed
		{
			add
			{
				lock (api.TokenRefreshed)
				{
					api.TokenRefreshed += value;
				}
			}

			remove
			{
				lock (api.TokenRefreshed)
				{
					api.TokenRefreshed -= value;
				}
			}
		}

		public ApiClient()
			: this(AssemblyEnvironment.Production)
		{
		}

		public ApiClient(AssemblyEnvironment environment)
		{
			var endpoint = string.Empty;

			switch (environment)
			{
				case AssemblyEnvironment.Sandbox:
					endpoint = "https://api-sandbox.assembly.education";
					break;
				default:
					endpoint = "https://api.assembly.education";
					break;
			}

			var httpClient = new HttpClient
			{
				BaseAddress = new Uri(endpoint)
			};

			this.api = new Api(httpClient);
		}

		public ApiClient(Api api)
		{
			this.api = api;
		}

		public virtual async Task<T> PostData<T>(string uri, object data)
		{
			var result = await api.PostData<T>(uri, data);
			return result;
		}

		public virtual async Task<IList<T>> GetList<T>(string resource, ExpandoObject args)
		{
			var results = await api.GetList<T>(resource, args);
			return results;
		}

		public virtual async Task<T> GetObject<T>(string resource, ExpandoObject args)
		{
			var results = await api.GetObject<T>(resource, args);
			return results;
		}

		public virtual void Configure(ApiConfiguration config)
		{
			this.api.Configuration = config;
		}
	}
}
