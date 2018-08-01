# AssemblyClient.Api.AssessmentsApi

All URIs are relative to *http://api-sandbox.lvh.me:3020*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Assessments**](AssessmentsApi.md#assessments) | **GET** /assessments | List Assessments


<a name="assessments"></a>
# **Assessments**
> AssessmentList Assessments (int? misMappings = null, int? perPage = null, int? page = null)

List Assessments

Returns a list of assessment objects. The assessment is the grouping that knits togethera range of concepts. The name of the assessment also refers to the source of the result.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class AssessmentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AssessmentsApi();
            var misMappings = 56;  // int? | includes the names of any MIS assessments (e.g. SIMS Aspects) that have been mapped to the assessment (optional) 
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)

            try
            {
                // List Assessments
                AssessmentList result = apiInstance.Assessments(misMappings, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.Assessments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **misMappings** | **int?**| includes the names of any MIS assessments (e.g. SIMS Aspects) that have been mapped to the assessment | [optional] 
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **page** | **int?**| Page number to return | [optional] [default to 1]

### Return type

[**AssessmentList**](AssessmentList.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

