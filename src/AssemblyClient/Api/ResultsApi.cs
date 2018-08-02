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
    public interface IResultsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Results
        /// </summary>
        /// <remarks>
        /// Returns a list of results for the student ID(s) specified by the students parameter.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded).</param>
        /// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>ResultList</returns>
        ResultList Results (List<int?> students, DateTime? ifModifiedSince = null, int? perPage = null, int? page = null);

        /// <summary>
        /// List Results
        /// </summary>
        /// <remarks>
        /// Returns a list of results for the student ID(s) specified by the students parameter.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded).</param>
        /// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>ApiResponse of ResultList</returns>
        ApiResponse<ResultList> ResultsWithHttpInfo (List<int?> students, DateTime? ifModifiedSince = null, int? perPage = null, int? page = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List Results
        /// </summary>
        /// <remarks>
        /// Returns a list of results for the student ID(s) specified by the students parameter.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded).</param>
        /// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of ResultList</returns>
        System.Threading.Tasks.Task<ResultList> ResultsAsync (List<int?> students, DateTime? ifModifiedSince = null, int? perPage = null, int? page = null);

        /// <summary>
        /// List Results
        /// </summary>
        /// <remarks>
        /// Returns a list of results for the student ID(s) specified by the students parameter.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded).</param>
        /// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ResultList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResultList>> ResultsAsyncWithHttpInfo (List<int?> students, DateTime? ifModifiedSince = null, int? perPage = null, int? page = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ResultsApi : IResultsApi
    {
        private AssemblyClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ResultsApi(String basePath)
        {
            this.Configuration = new AssemblyClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AssemblyClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ResultsApi(AssemblyClient.Client.Configuration configuration = null)
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
        /// List Results Returns a list of results for the student ID(s) specified by the students parameter.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded).</param>
        /// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>ResultList</returns>
        public ResultList Results (List<int?> students, DateTime? ifModifiedSince = null, int? perPage = null, int? page = null)
        {
             ApiResponse<ResultList> localVarResponse = ResultsWithHttpInfo(students, ifModifiedSince, perPage, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Results Returns a list of results for the student ID(s) specified by the students parameter.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded).</param>
        /// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>ApiResponse of ResultList</returns>
        public ApiResponse< ResultList > ResultsWithHttpInfo (List<int?> students, DateTime? ifModifiedSince = null, int? perPage = null, int? page = null)
        {
            // verify the required parameter 'students' is set
            if (students == null)
                throw new ApiException(400, "Missing required parameter 'students' when calling ResultsApi->Results");

            var localVarPath = "/results";
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

            if (students != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "students[]", students)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (ifModifiedSince != null) localVarHeaderParams.Add("If-Modified-Since", this.Configuration.ApiClient.ParameterToString(ifModifiedSince)); // header parameter

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
                Exception exception = ExceptionFactory("Results", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResultList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResultList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResultList)));
        }

        /// <summary>
        /// List Results Returns a list of results for the student ID(s) specified by the students parameter.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded).</param>
        /// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of ResultList</returns>
        public async System.Threading.Tasks.Task<ResultList> ResultsAsync (List<int?> students, DateTime? ifModifiedSince = null, int? perPage = null, int? page = null)
        {
             ApiResponse<ResultList> localVarResponse = await ResultsAsyncWithHttpInfo(students, ifModifiedSince, perPage, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Results Returns a list of results for the student ID(s) specified by the students parameter.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="students">ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded).</param>
        /// <param name="ifModifiedSince">If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ResultList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResultList>> ResultsAsyncWithHttpInfo (List<int?> students, DateTime? ifModifiedSince = null, int? perPage = null, int? page = null)
        {
            // verify the required parameter 'students' is set
            if (students == null)
                throw new ApiException(400, "Missing required parameter 'students' when calling ResultsApi->Results");

            var localVarPath = "/results";
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

            if (students != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "students[]", students)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (ifModifiedSince != null) localVarHeaderParams.Add("If-Modified-Since", this.Configuration.ApiClient.ParameterToString(ifModifiedSince)); // header parameter

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
                Exception exception = ExceptionFactory("Results", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ResultList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResultList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResultList)));
        }

    }
}
