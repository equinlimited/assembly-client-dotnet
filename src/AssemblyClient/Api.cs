using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AssemblyClient
{
    public class Api
    {
        private readonly HttpClient client;

        public ApiConfiguration Configuration { get; set; }

        public EventHandler<TokenRefreshedEventArgs> TokenRefreshed { get; set; }

        internal void OnTokenRefreshed(string newToken)
        {
            if (TokenRefreshed != null)
            {
                TokenRefreshed(this, new TokenRefreshedEventArgs { Token = newToken });
            }
        }

        public Api()
        {
        }

        public Api(HttpClient client)
        {
            this.client = client;
            this.client.DefaultRequestHeaders.Add("Accept", "application/vnd.assembly+json; version=1.1");
            this.TokenRefreshed += (sender, args) => { };
        }

        public virtual async Task<T> PostData<T>(string uri, object data)
        {
            var response = await client.PostData(uri, Configuration.Token, data);
            var isTokenValid = await response.IsValidToken();

            if (Configuration.Debug)
            {
                Console.WriteLine($"Assembly API POST: {uri}");
            }

            if (!isTokenValid)
            {
                var newToken = await RefreshToken(Configuration.RefreshToken);
                Configuration.Token = newToken;

                OnTokenRefreshed(newToken);

                response = await client.PostData(uri, Configuration.Token, data);
                await response.EnsurePlatformSuccess();
            }
            else
            {
                await response.EnsurePlatformSuccess();
            }

            var result = await response.Deserialize<T>();
            return result;
        }

        public virtual async Task<HttpResponseMessage> Load(string resource)
        {
            var result = await Load(resource, new ExpandoObject());
            return result;
        }

        private async Task<string> RefreshToken(string refreshToken)
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Configuration.BasicAuth);

            var refreshRequest = new ApiGrant(refreshToken);
            var response = await client.PostData("/oauth/token", Configuration.Token, refreshRequest);

            if (Configuration.Debug)
            {
                Console.WriteLine($"Assembly API Token Refresh");
            }

            await response.EnsurePlatformSuccess();

            var refreshedToken = await response.Deserialize();
            return refreshedToken.access_token;
        }

        public virtual async Task<HttpResponseMessage> Load(string resource, ExpandoObject args)
        {
            var parsedArgs = (IDictionary<String, Object>) args;

            if (parsedArgs.ContainsKey("ifModifiedSince") && parsedArgs["ifModifiedSince"] != null)
            {
                this.client.DefaultRequestHeaders.Add("If-Modified-Since", ((DateTime)parsedArgs["ifModifiedSince"]).ToString("r"));
                parsedArgs.Remove("ifModifiedSince");
            }

            args = (ExpandoObject) parsedArgs;

            var query = args.ToParams();
            var resourceWithQuery = $"{resource}";

            if (!string.IsNullOrEmpty(query))
            {
                resourceWithQuery = $"{resourceWithQuery}?{query}";
            }

            if (Configuration.Debug)
            {
                Console.WriteLine($"Assembly API GET: {resourceWithQuery}");
            }

            var response = await client.MakeRequest(resourceWithQuery, Configuration.Token);
            var isTokenValid = await response.IsValidToken();

            if (!isTokenValid)
            {
                var newToken = await RefreshToken(Configuration.RefreshToken);
                Configuration.Token = newToken;

                OnTokenRefreshed(newToken);

                response = await client.MakeRequest(resourceWithQuery, Configuration.Token);
                await response.EnsurePlatformSuccess();
            }
            else
            {
                await response.EnsurePlatformSuccess();
            }

            return response;
        }

        private ExpandoObject FormatData(IDictionary<string, object> me)
        {
            var target = (IDictionary<string, object>)new ExpandoObject();

            foreach (var v in me)
            {
                if (v.Key == "object")
                {
                    continue;
                }

                target.Add(v.Key.ToProperty(), v.Value);
            }

            return (ExpandoObject)target;
        }

        public virtual async Task<IList<T>> GetList<T>(string resource, ExpandoObject args)
        {
            var results = new List<T>();
            bool allPages = true;
            dynamic queryArgs = args;
            int page;

            if (((IDictionary<String, Object>) queryArgs).TryGetValue("page", out page) && page != null)
            {
                allPages = false;
            }
            else
            {
                queryArgs.page = 1;
            }

            do
            {
                try
                {
                    var response = await Load(resource, queryArgs);

                    var data = await response.Content.ReadAsStringAsync();

                    var list = JsonConvert.DeserializeObject<List<T>>(data);

                    results.AddRange(list);

                    var nextPage = response
                        .Headers
                        .GetValues("Next-Page")[0];

                    if (string.IsNullOrEmpty(nextPage) || !allPages)
                    {
                        queryArgs.page = null;
                    }
                    else
                    {
                        queryArgs.page = int.Parse(nextPage);
                    }
                }
                catch (RequestThrottledException ex)
                {
                    var waitingPeriod = ex.Period * 1000;
                    if (Configuration.Debug)
                    {
                        Console.WriteLine($"Assembly API rate limit hit at {DateTime.Now} due to reaching {ex.Count} requests in {ex.Period} seconds when limit is {ex.Limit} waiting {ex.Period} second before retrying");
                    }
                    await Task.Delay(waitingPeriod);
                    if (Configuration.Debug)
                    {
                        Console.WriteLine($"Assembly API rate limit hit waited period of {ex.Period} seconds finished at {DateTime.Now} now retrying");
                    }
                }

            } while (queryArgs.page != null);

            return results;
        }

        public virtual async Task<T> GetObject<T>(string resource, ExpandoObject args)
        {
            var data = await Load(resource, args);
            var rawData = await data.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<T>(rawData);
            return obj;
        }
    }
}
