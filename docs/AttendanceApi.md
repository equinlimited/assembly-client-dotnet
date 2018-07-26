# AssemblyClient.Api.AttendanceApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAttendances**](AttendanceApi.md#getattendances) | **GET** /attendances | 


<a name="getattendances"></a>
# **GetAttendances**
> AttendanceList GetAttendances (int? studentId = null, int? registrationGroupId = null, string startDate = null, string endDate = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of attendances, filtered by date, student, or registration group. By default, attendances are returned from the start to the end of the current week.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetAttendancesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendanceApi();
            var studentId = 56;  // int? | ID of the Student as an Integer (optional) 
            var registrationGroupId = 56;  // int? | ID of the registration group as an Integer (optional) 
            var startDate = startDate_example;  // string | The start date of the period to return data for (optional) 
            var endDate = endDate_example;  // string | The end date of the period to return data for (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                AttendanceList result = apiInstance.GetAttendances(studentId, registrationGroupId, startDate, endDate, page, perPage, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendanceApi.GetAttendances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentId** | **int?**| ID of the Student as an Integer | [optional] 
 **registrationGroupId** | **int?**| ID of the registration group as an Integer | [optional] 
 **startDate** | **string**| The start date of the period to return data for | [optional] 
 **endDate** | **string**| The end date of the period to return data for | [optional] 
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **ifModifiedSince** | **string**| Timestamp of the last response. | [optional] 

### Return type

[**AttendanceList**](AttendanceList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

