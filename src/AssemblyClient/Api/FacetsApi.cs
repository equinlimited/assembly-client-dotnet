/* 
 * Assembly Developer API
 *
 * The Assembly API is built around the REST and a collection of open standards/protocols in order to comply with as many consumers as possible.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: help@assembly.education
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace AssemblyClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFacetsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// View a Facet
        /// </summary>
        /// <remarks>
        /// Returns a single facet for the given id.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the Facet</param>
        /// <returns>Facet</returns>
        Facet Facet (int? id);

        /// <summary>
        /// View a Facet
        /// </summary>
        /// <remarks>
        /// Returns a single facet for the given id.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the Facet</param>
        /// <returns>ApiResponse of Facet</returns>
        ApiResponse<Facet> FacetWithHttpInfo (int? id);
        /// <summary>
        /// List Facets
        /// </summary>
        /// <remarks>
        /// Returns a list of facets. The facet is used to reflect a different type of grade and allows 2 grades of the same assessment to be compared.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>FacetList</returns>
        FacetList Facets (int? perPage = null, int? page = null);

        /// <summary>
        /// List Facets
        /// </summary>
        /// <remarks>
        /// Returns a list of facets. The facet is used to reflect a different type of grade and allows 2 grades of the same assessment to be compared.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>ApiResponse of FacetList</returns>
        ApiResponse<FacetList> FacetsWithHttpInfo (int? perPage = null, int? page = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// View a Facet
        /// </summary>
        /// <remarks>
        /// Returns a single facet for the given id.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the Facet</param>
        /// <returns>Task of Facet</returns>
        System.Threading.Tasks.Task<Facet> FacetAsync (int? id);

        /// <summary>
        /// View a Facet
        /// </summary>
        /// <remarks>
        /// Returns a single facet for the given id.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the Facet</param>
        /// <returns>Task of ApiResponse (Facet)</returns>
        System.Threading.Tasks.Task<ApiResponse<Facet>> FacetAsyncWithHttpInfo (int? id);
        /// <summary>
        /// List Facets
        /// </summary>
        /// <remarks>
        /// Returns a list of facets. The facet is used to reflect a different type of grade and allows 2 grades of the same assessment to be compared.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of FacetList</returns>
        System.Threading.Tasks.Task<FacetList> FacetsAsync (int? perPage = null, int? page = null);

        /// <summary>
        /// List Facets
        /// </summary>
        /// <remarks>
        /// Returns a list of facets. The facet is used to reflect a different type of grade and allows 2 grades of the same assessment to be compared.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (FacetList)</returns>
        System.Threading.Tasks.Task<ApiResponse<FacetList>> FacetsAsyncWithHttpInfo (int? perPage = null, int? page = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FacetsApi : IFacetsApi
    {
        private AssemblyClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FacetsApi(String basePath)
        {
            this.Configuration = new AssemblyClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AssemblyClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FacetsApi(AssemblyClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = AssemblyClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = AssemblyClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AssemblyClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AssemblyClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// View a Facet Returns a single facet for the given id.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the Facet</param>
        /// <returns>Facet</returns>
        public Facet Facet (int? id)
        {
             ApiResponse<Facet> localVarResponse = FacetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// View a Facet Returns a single facet for the given id.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the Facet</param>
        /// <returns>ApiResponse of Facet</returns>
        public ApiResponse< Facet > FacetWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FacetsApi->Facet");

            var localVarPath = "/facets/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Facet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Facet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Facet) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Facet)));
        }

        /// <summary>
        /// View a Facet Returns a single facet for the given id.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the Facet</param>
        /// <returns>Task of Facet</returns>
        public async System.Threading.Tasks.Task<Facet> FacetAsync (int? id)
        {
             ApiResponse<Facet> localVarResponse = await FacetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// View a Facet Returns a single facet for the given id.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id of the Facet</param>
        /// <returns>Task of ApiResponse (Facet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Facet>> FacetAsyncWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FacetsApi->Facet");

            var localVarPath = "/facets/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Facet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Facet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Facet) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Facet)));
        }

        /// <summary>
        /// List Facets Returns a list of facets. The facet is used to reflect a different type of grade and allows 2 grades of the same assessment to be compared.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>FacetList</returns>
        public FacetList Facets (int? perPage = null, int? page = null)
        {
             ApiResponse<FacetList> localVarResponse = FacetsWithHttpInfo(perPage, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Facets Returns a list of facets. The facet is used to reflect a different type of grade and allows 2 grades of the same assessment to be compared.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>ApiResponse of FacetList</returns>
        public ApiResponse< FacetList > FacetsWithHttpInfo (int? perPage = null, int? page = null)
        {

            var localVarPath = "/facets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Facets", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FacetList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FacetList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacetList)));
        }

        /// <summary>
        /// List Facets Returns a list of facets. The facet is used to reflect a different type of grade and allows 2 grades of the same assessment to be compared.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of FacetList</returns>
        public async System.Threading.Tasks.Task<FacetList> FacetsAsync (int? perPage = null, int? page = null)
        {
             ApiResponse<FacetList> localVarResponse = await FacetsAsyncWithHttpInfo(perPage, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Facets Returns a list of facets. The facet is used to reflect a different type of grade and allows 2 grades of the same assessment to be compared.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (FacetList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FacetList>> FacetsAsyncWithHttpInfo (int? perPage = null, int? page = null)
        {

            var localVarPath = "/facets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Facets", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FacetList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FacetList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FacetList)));
        }

    }
}
