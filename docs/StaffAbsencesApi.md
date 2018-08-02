# AssemblyClient.Api.StaffAbsencesApi

All URIs are relative to *http://api-sandbox.lvh.me:3020*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StaffAbscences**](StaffAbsencesApi.md#staffabscences) | **GET** /staff_absences | List Staff Absences


<a name="staffabscences"></a>
# **StaffAbscences**
> StaffAbsenceList StaffAbscences (int? staffMemberId = null, string startDate = null, string qualifications = null, DateTime? ifModifiedSince = null, int? perPage = null, int? page = null)

List Staff Absences

Returns a list of staff member absences for the school accociated with the provided `access_token`. A school level access token with the `staff_members.absences` scope is required to access staff member absence information.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class StaffAbscencesExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StaffAbsencesApi();
            var staffMemberId = 56;  // int? | show only absences fot the specified staff member (optional) 
            var startDate = startDate_example;  // string | the start date of the period to return staff absences for (optional)  (default to "start of academic year")
            var qualifications = qualifications_example;  // string | include HLTA status, QT status, QT route and previous degree information (requires `staff_members.qualifications` scope) (optional)  (default to "end of academic year")
            var ifModifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional) 
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)

            try
            {
                // List Staff Absences
                StaffAbsenceList result = apiInstance.StaffAbscences(staffMemberId, startDate, qualifications, ifModifiedSince, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffAbsencesApi.StaffAbscences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffMemberId** | **int?**| show only absences fot the specified staff member | [optional] 
 **startDate** | **string**| the start date of the period to return staff absences for | [optional] [default to &quot;start of academic year&quot;]
 **qualifications** | **string**| include HLTA status, QT status, QT route and previous degree information (requires &#x60;staff_members.qualifications&#x60; scope) | [optional] [default to &quot;end of academic year&quot;]
 **ifModifiedSince** | **DateTime?**| If-Modified-Since is optional (see the page on Conditional Requests for more details). | [optional] 
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **page** | **int?**| Page number to return | [optional] [default to 1]

### Return type

[**StaffAbsenceList**](StaffAbsenceList.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

