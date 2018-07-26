# assembly-client-dotnet.Api.ExclusionsApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetExclusions**](ExclusionsApi.md#getexclusions) | **GET** /exclusions | 
[**GetExclusionsStudentId**](ExclusionsApi.md#getexclusionsstudentid) | **GET** /exclusions/{student_id} | 


<a name="getexclusions"></a>
# **GetExclusions**
> ExclusionList GetExclusions (string startDate = null, string endDate = null, int? page = null, int? perPage = null)



Returns a list of exclusions. By default, exclusions are returned that occurred during the current academic year.

### Example
```csharp
using System;
using System.Diagnostics;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace Example
{
    public class GetExclusionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExclusionsApi();
            var startDate = startDate_example;  // string | The start date of the period to return data for (optional) 
            var endDate = endDate_example;  // string | The end date of the period to return data for (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)

            try
            {
                ExclusionList result = apiInstance.GetExclusions(startDate, endDate, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExclusionsApi.GetExclusions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| The start date of the period to return data for | [optional] 
 **endDate** | **string**| The end date of the period to return data for | [optional] 
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]

### Return type

[**ExclusionList**](ExclusionList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexclusionsstudentid"></a>
# **GetExclusionsStudentId**
> ExclusionList GetExclusionsStudentId (string studentId, string startDate = null, string endDate = null, int? page = null, int? perPage = null)



Returns a list of exclusions for a given student. By default, exclusions are returned that occurred during the current academic year.

### Example
```csharp
using System;
using System.Diagnostics;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace Example
{
    public class GetExclusionsStudentIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExclusionsApi();
            var studentId = studentId_example;  // string | ID of the Student as an Integer
            var startDate = startDate_example;  // string | The start date of the period to return data for (optional) 
            var endDate = endDate_example;  // string | The end date of the period to return data for (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)

            try
            {
                ExclusionList result = apiInstance.GetExclusionsStudentId(studentId, startDate, endDate, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExclusionsApi.GetExclusionsStudentId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentId** | **string**| ID of the Student as an Integer | 
 **startDate** | **string**| The start date of the period to return data for | [optional] 
 **endDate** | **string**| The end date of the period to return data for | [optional] 
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]

### Return type

[**ExclusionList**](ExclusionList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

