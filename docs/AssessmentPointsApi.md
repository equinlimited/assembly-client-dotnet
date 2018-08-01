# AssemblyClient.Api.AssessmentPointsApi

All URIs are relative to *http://api-sandbox.lvh.me:3020*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssessmentPoint**](AssessmentPointsApi.md#assessmentpoint) | **GET** /assessment_points/{id} | View an Assessment Point
[**AssessmentPointResults**](AssessmentPointsApi.md#assessmentpointresults) | **GET** /assessment_points/{id}/results | View Results for an Assessment Point
[**AssessmentPoints**](AssessmentPointsApi.md#assessmentpoints) | **GET** /assessment_points | List Assessment Points


<a name="assessmentpoint"></a>
# **AssessmentPoint**
> string AssessmentPoint (int? id)

View an Assessment Point

Returns a single assessment point for the given rank.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class AssessmentPointExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AssessmentPointsApi();
            var id = 56;  // int? | id of the AssessmentPoint

            try
            {
                // View an Assessment Point
                string result = apiInstance.AssessmentPoint(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentPointsApi.AssessmentPoint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the AssessmentPoint | 

### Return type

**string**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assessmentpointresults"></a>
# **AssessmentPointResults**
> ResultList AssessmentPointResults (int? assessmentPointRank, string students, int? perPage = null, int? page = null)

View Results for an Assessment Point

Returns a list of results for the given assessment_point_rank and students.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class AssessmentPointResultsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AssessmentPointsApi();
            var assessmentPointRank = 56;  // int? | the Assessment Point rank
            var students = students_example;  // string | ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded).
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)

            try
            {
                // View Results for an Assessment Point
                ResultList result = apiInstance.AssessmentPointResults(assessmentPointRank, students, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentPointsApi.AssessmentPointResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assessmentPointRank** | **int?**| the Assessment Point rank | 
 **students** | **string**| ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded). | 
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **page** | **int?**| Page number to return | [optional] [default to 1]

### Return type

[**ResultList**](ResultList.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assessmentpoints"></a>
# **AssessmentPoints**
> AssessmentPointList AssessmentPoints (int? perPage = null, int? page = null)

List Assessment Points

Returns a list of assessment points. An assessment_point object represents a point in the school key stage, year, term or half-term that results can be attached to. When sending results back to the Platform, the assessment_point_rank should be used - this will remain constant across all environments.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class AssessmentPointsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AssessmentPointsApi();
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)

            try
            {
                // List Assessment Points
                AssessmentPointList result = apiInstance.AssessmentPoints(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentPointsApi.AssessmentPoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **page** | **int?**| Page number to return | [optional] [default to 1]

### Return type

[**AssessmentPointList**](AssessmentPointList.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

