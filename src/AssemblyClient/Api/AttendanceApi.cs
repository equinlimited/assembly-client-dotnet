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
    public interface IAttendanceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of attendances, filtered by date, student, or registration group. By default, attendances are returned from the start to the end of the current week.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer (optional)</param>
        /// <param name="registrationGroupId">ID of the registration group as an Integer (optional)</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="ifModifiedSince">Timestamp of the last response. (optional)</param>
        /// <returns>AttendanceList</returns>
        AttendanceList Attendances (int? studentId = null, int? registrationGroupId = null, string startDate = null, string endDate = null, int? page = null, int? perPage = null, string ifModifiedSince = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of attendances, filtered by date, student, or registration group. By default, attendances are returned from the start to the end of the current week.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer (optional)</param>
        /// <param name="registrationGroupId">ID of the registration group as an Integer (optional)</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="ifModifiedSince">Timestamp of the last response. (optional)</param>
        /// <returns>ApiResponse of AttendanceList</returns>
        ApiResponse<AttendanceList> AttendancesWithHttpInfo (int? studentId = null, int? registrationGroupId = null, string startDate = null, string endDate = null, int? page = null, int? perPage = null, string ifModifiedSince = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of attendances, filtered by date, student, or registration group. By default, attendances are returned from the start to the end of the current week.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer (optional)</param>
        /// <param name="registrationGroupId">ID of the registration group as an Integer (optional)</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="ifModifiedSince">Timestamp of the last response. (optional)</param>
        /// <returns>Task of AttendanceList</returns>
        System.Threading.Tasks.Task<AttendanceList> AttendancesAsync (int? studentId = null, int? registrationGroupId = null, string startDate = null, string endDate = null, int? page = null, int? perPage = null, string ifModifiedSince = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of attendances, filtered by date, student, or registration group. By default, attendances are returned from the start to the end of the current week.
        /// </remarks>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer (optional)</param>
        /// <param name="registrationGroupId">ID of the registration group as an Integer (optional)</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="ifModifiedSince">Timestamp of the last response. (optional)</param>
        /// <returns>Task of ApiResponse (AttendanceList)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttendanceList>> AttendancesAsyncWithHttpInfo (int? studentId = null, int? registrationGroupId = null, string startDate = null, string endDate = null, int? page = null, int? perPage = null, string ifModifiedSince = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AttendanceApi : IAttendanceApi
    {
        private AssemblyClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AttendanceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttendanceApi(String basePath)
        {
            this.Configuration = new AssemblyClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AssemblyClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttendanceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AttendanceApi(AssemblyClient.Client.Configuration configuration = null)
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
        ///  Returns a list of attendances, filtered by date, student, or registration group. By default, attendances are returned from the start to the end of the current week.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer (optional)</param>
        /// <param name="registrationGroupId">ID of the registration group as an Integer (optional)</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="ifModifiedSince">Timestamp of the last response. (optional)</param>
        /// <returns>AttendanceList</returns>
        public AttendanceList Attendances (int? studentId = null, int? registrationGroupId = null, string startDate = null, string endDate = null, int? page = null, int? perPage = null, string ifModifiedSince = null)
        {
             ApiResponse<AttendanceList> localVarResponse = AttendancesWithHttpInfo(studentId, registrationGroupId, startDate, endDate, page, perPage, ifModifiedSince);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns a list of attendances, filtered by date, student, or registration group. By default, attendances are returned from the start to the end of the current week.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer (optional)</param>
        /// <param name="registrationGroupId">ID of the registration group as an Integer (optional)</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="ifModifiedSince">Timestamp of the last response. (optional)</param>
        /// <returns>ApiResponse of AttendanceList</returns>
        public ApiResponse< AttendanceList > AttendancesWithHttpInfo (int? studentId = null, int? registrationGroupId = null, string startDate = null, string endDate = null, int? page = null, int? perPage = null, string ifModifiedSince = null)
        {

            var localVarPath = "/attendances";
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

            if (studentId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "student_id", studentId)); // query parameter
            if (registrationGroupId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "registration_group_id", registrationGroupId)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter
            if (ifModifiedSince != null) localVarHeaderParams.Add("If-Modified-Since", this.Configuration.ApiClient.ParameterToString(ifModifiedSince)); // header parameter

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
                Exception exception = ExceptionFactory("Attendances", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AttendanceList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttendanceList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttendanceList)));
        }

        /// <summary>
        ///  Returns a list of attendances, filtered by date, student, or registration group. By default, attendances are returned from the start to the end of the current week.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer (optional)</param>
        /// <param name="registrationGroupId">ID of the registration group as an Integer (optional)</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="ifModifiedSince">Timestamp of the last response. (optional)</param>
        /// <returns>Task of AttendanceList</returns>
        public async System.Threading.Tasks.Task<AttendanceList> AttendancesAsync (int? studentId = null, int? registrationGroupId = null, string startDate = null, string endDate = null, int? page = null, int? perPage = null, string ifModifiedSince = null)
        {
             ApiResponse<AttendanceList> localVarResponse = await AttendancesAsyncWithHttpInfo(studentId, registrationGroupId, startDate, endDate, page, perPage, ifModifiedSince);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Returns a list of attendances, filtered by date, student, or registration group. By default, attendances are returned from the start to the end of the current week.
        /// </summary>
        /// <exception cref="AssemblyClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="studentId">ID of the Student as an Integer (optional)</param>
        /// <param name="registrationGroupId">ID of the registration group as an Integer (optional)</param>
        /// <param name="startDate">The start date of the period to return data for (optional)</param>
        /// <param name="endDate">The end date of the period to return data for (optional)</param>
        /// <param name="page">Page number to return (optional, default to 1)</param>
        /// <param name="perPage">Number of results to return (optional, default to 100)</param>
        /// <param name="ifModifiedSince">Timestamp of the last response. (optional)</param>
        /// <returns>Task of ApiResponse (AttendanceList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttendanceList>> AttendancesAsyncWithHttpInfo (int? studentId = null, int? registrationGroupId = null, string startDate = null, string endDate = null, int? page = null, int? perPage = null, string ifModifiedSince = null)
        {

            var localVarPath = "/attendances";
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

            if (studentId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "student_id", studentId)); // query parameter
            if (registrationGroupId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "registration_group_id", registrationGroupId)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (perPage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "per_page", perPage)); // query parameter
            if (ifModifiedSince != null) localVarHeaderParams.Add("If-Modified-Since", this.Configuration.ApiClient.ParameterToString(ifModifiedSince)); // header parameter

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
                Exception exception = ExceptionFactory("Attendances", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AttendanceList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttendanceList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttendanceList)));
        }

    }
}