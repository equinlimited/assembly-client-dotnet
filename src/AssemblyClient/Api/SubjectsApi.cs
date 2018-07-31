/* 
 * assembly.education
 *
 * Developer API for assembly.education.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: help@assembly.education
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
    public interface ISubjectsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of the Assembly Platform&#39;s subjects.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="misMappings">Includes the names of any MIS components to this object (optional, default to false)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>SubjectList</returns>
        SubjectList Subjects (bool? misMappings = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of the Assembly Platform&#39;s subjects.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="misMappings">Includes the names of any MIS components to this object (optional, default to false)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of SubjectList</returns>
        ApiResponse<SubjectList> SubjectsWithHttpInfo (bool? misMappings = null, int? page = null, int? perPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of the Assembly Platform&#39;s subjects.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="misMappings">Includes the names of any MIS components to this object (optional, default to false)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of SubjectList</returns>
        System.Threading.Tasks.Task<SubjectList> SubjectsAsync (bool? misMappings = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of the Assembly Platform&#39;s subjects.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="misMappings">Includes the names of any MIS components to this object (optional, default to false)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (SubjectList)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubjectList>> SubjectsAsyncWithHttpInfo (bool? misMappings = null, int? page = null, int? perPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubjectsApi : ISubjectsApi
    {
        private AssemblyClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubjectsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubjectsApi(String basePath)
        {
            this.Configuration = new AssemblyClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AssemblyClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubjectsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubjectsApi(AssemblyClient.Client.Configuration configuration = null)
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
        ///  Returns a list of the Assembly Platform&#39;s subjects.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="misMappings">Includes the names of any MIS components to this object (optional, default to false)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>SubjectList</returns>
        public SubjectList Subjects (bool? misMappings = null, int? page = null, int? perPage = null)
        {
             ApiResponse<SubjectList> localVarResponse = SubjectsWithHttpInfo(misMappings, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns a list of the Assembly Platform&#39;s subjects.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="misMappings">Includes the names of any MIS components to this object (optional, default to false)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of SubjectList</returns>
        public ApiResponse< SubjectList > SubjectsWithHttpInfo (bool? misMappings = null, int? page = null, int? perPage = null)
        {

            var localVarPath = "/subjects";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (misMappings != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "mis_mappings", misMappings)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Subjects", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubjectList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubjectList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubjectList)));
        }

        /// <summary>
        ///  Returns a list of the Assembly Platform&#39;s subjects.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="misMappings">Includes the names of any MIS components to this object (optional, default to false)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of SubjectList</returns>
        public async System.Threading.Tasks.Task<SubjectList> SubjectsAsync (bool? misMappings = null, int? page = null, int? perPage = null)
        {
             ApiResponse<SubjectList> localVarResponse = await SubjectsAsyncWithHttpInfo(misMappings, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Returns a list of the Assembly Platform&#39;s subjects.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="misMappings">Includes the names of any MIS components to this object (optional, default to false)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (SubjectList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubjectList>> SubjectsAsyncWithHttpInfo (bool? misMappings = null, int? page = null, int? perPage = null)
        {

            var localVarPath = "/subjects";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.assembly+json; version=1"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (misMappings != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "mis_mappings", misMappings)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Subjects", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubjectList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubjectList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubjectList)));
        }

    }
}