# AssemblyClient.Api.AssessmentsApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAssessmentPoints**](AssessmentsApi.md#getassessmentpoints) | **GET** /assessment_points | 
[**GetAssessmentPointsAssessmentPointRank**](AssessmentsApi.md#getassessmentpointsassessmentpointrank) | **GET** /assessment_points/{assessment_point_rank} | 
[**GetAssessmentPointsAssessmentPointRankResults**](AssessmentsApi.md#getassessmentpointsassessmentpointrankresults) | **GET** /assessment_points/{assessment_point_rank}/results | 
[**GetAssessments**](AssessmentsApi.md#getassessments) | **GET** /assessments | 
[**GetAssessmentsAssessmentId**](AssessmentsApi.md#getassessmentsassessmentid) | **GET** /assessments/{assessment_id} | 
[**GetAssessmentsAssessmentIdGradeSet**](AssessmentsApi.md#getassessmentsassessmentidgradeset) | **GET** /assessments/{assessment_id}/grade_set | 
[**GetAssessmentsAssessmentIdResults**](AssessmentsApi.md#getassessmentsassessmentidresults) | **GET** /assessments/{assessment_id}/results | 
[**GetFacetFacetId**](AssessmentsApi.md#getfacetfacetid) | **GET** /facet/{facet_id} | 
[**GetFacets**](AssessmentsApi.md#getfacets) | **GET** /facets | 
[**PatchResults**](AssessmentsApi.md#patchresults) | **PATCH** /results | 
[**PatchResultsResultId**](AssessmentsApi.md#patchresultsresultid) | **PATCH** /results/{result_id} | 


<a name="getassessmentpoints"></a>
# **GetAssessmentPoints**
> AssessmentPointList GetAssessmentPoints (string yearCode = null, string type = null, int? page = null, int? perPage = null)



Returns a list of assessment points. An assessment_point object represents a point in the school key stage, year, term or half-term that results can be attached to. When sending results back to the Platform, the `assessment_point_rank` should be used - this will remain constant across all environments.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetAssessmentPointsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var yearCode = yearCode_example;  // string | Filter by a specific NC year code (optional) 
            var type = type_example;  // string | Filter by assessment point type (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)

            try
            {
                AssessmentPointList result = apiInstance.GetAssessmentPoints(yearCode, type, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.GetAssessmentPoints: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **yearCode** | **string**| Filter by a specific NC year code | [optional] 
 **type** | **string**| Filter by assessment point type | [optional] 
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]

### Return type

[**AssessmentPointList**](AssessmentPointList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessmentpointsassessmentpointrank"></a>
# **GetAssessmentPointsAssessmentPointRank**
> AssessmentPoint GetAssessmentPointsAssessmentPointRank (string assessmentPointRank)



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
    public class GetAssessmentPointsAssessmentPointRankExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var assessmentPointRank = assessmentPointRank_example;  // string | The rank of the assessment point as an Integer

            try
            {
                AssessmentPoint result = apiInstance.GetAssessmentPointsAssessmentPointRank(assessmentPointRank);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.GetAssessmentPointsAssessmentPointRank: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assessmentPointRank** | **string**| The rank of the assessment point as an Integer | 

### Return type

[**AssessmentPoint**](AssessmentPoint.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessmentpointsassessmentpointrankresults"></a>
# **GetAssessmentPointsAssessmentPointRankResults**
> ResultList GetAssessmentPointsAssessmentPointRankResults (string assessmentPointRank, string students = null, int? page = null, int? perPage = null)



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
    public class GetAssessmentPointsAssessmentPointRankResultsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var assessmentPointRank = assessmentPointRank_example;  // string | The rank of the assessment point as an Integer
            var students = students_example;  // string | ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded). (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)

            try
            {
                ResultList result = apiInstance.GetAssessmentPointsAssessmentPointRankResults(assessmentPointRank, students, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.GetAssessmentPointsAssessmentPointRankResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assessmentPointRank** | **string**| The rank of the assessment point as an Integer | 
 **students** | **string**| ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded). | [optional] 
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]

### Return type

[**ResultList**](ResultList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessments"></a>
# **GetAssessments**
> AssessmentList GetAssessments (bool? misMappings = null, int? page = null, int? perPage = null)



Returns a list of assessment objects.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetAssessmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var misMappings = true;  // bool? | Includes the names of any MIS components to this object (optional)  (default to false)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)

            try
            {
                AssessmentList result = apiInstance.GetAssessments(misMappings, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.GetAssessments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **misMappings** | **bool?**| Includes the names of any MIS components to this object | [optional] [default to false]
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]

### Return type

[**AssessmentList**](AssessmentList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessmentsassessmentid"></a>
# **GetAssessmentsAssessmentId**
> Assessment GetAssessmentsAssessmentId (string assessmentId)



Returns a single assessment for the given ID.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetAssessmentsAssessmentIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var assessmentId = assessmentId_example;  // string | ID of the assessment as an Integer.

            try
            {
                Assessment result = apiInstance.GetAssessmentsAssessmentId(assessmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.GetAssessmentsAssessmentId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assessmentId** | **string**| ID of the assessment as an Integer. | 

### Return type

[**Assessment**](Assessment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessmentsassessmentidgradeset"></a>
# **GetAssessmentsAssessmentIdGradeSet**
> Gradeset GetAssessmentsAssessmentIdGradeSet (string assessmentId)



Returns a gradeset (an acceptable list of values) for the assessment identified by the assessment_id. Grades should be written back to the Platform using the grade_id.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetAssessmentsAssessmentIdGradeSetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var assessmentId = assessmentId_example;  // string | ID of the assessment as an Integer.

            try
            {
                Gradeset result = apiInstance.GetAssessmentsAssessmentIdGradeSet(assessmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.GetAssessmentsAssessmentIdGradeSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assessmentId** | **string**| ID of the assessment as an Integer. | 

### Return type

[**Gradeset**](Gradeset.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessmentsassessmentidresults"></a>
# **GetAssessmentsAssessmentIdResults**
> Result GetAssessmentsAssessmentIdResults (string assessmentId, string students = null)



Returns a list of results for the given assessment_id and students. For a full list of national assessment data (Key stage 1 and 2 SATs results) available on the Platform, please see this support article.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetAssessmentsAssessmentIdResultsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var assessmentId = assessmentId_example;  // string | ID of the assessment as an Integer.
            var students = students_example;  // string | ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded). (optional) 

            try
            {
                Result result = apiInstance.GetAssessmentsAssessmentIdResults(assessmentId, students);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.GetAssessmentsAssessmentIdResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assessmentId** | **string**| ID of the assessment as an Integer. | 
 **students** | **string**| ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded). | [optional] 

### Return type

[**Result**](Result.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfacetfacetid"></a>
# **GetFacetFacetId**
> Facet GetFacetFacetId (string facetId)



Returns a single facet for the given ID.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetFacetFacetIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var facetId = facetId_example;  // string | ID of the facet as an Integer.

            try
            {
                Facet result = apiInstance.GetFacetFacetId(facetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.GetFacetFacetId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **facetId** | **string**| ID of the facet as an Integer. | 

### Return type

[**Facet**](Facet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfacets"></a>
# **GetFacets**
> FacetList GetFacets (int? page = null, int? perPage = null)



Returns a list of facets. The facet is used to reflect a different type of grade and allows 2 grades of the same assessment to be compared.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetFacetsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)

            try
            {
                FacetList result = apiInstance.GetFacets(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.GetFacets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]

### Return type

[**FacetList**](FacetList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchresults"></a>
# **PatchResults**
> UpdateMultipleResultResponse PatchResults (UpdateMultipleResultResponse updateMultipleResultPayload = null)



Multiple results can be updated simultaneously by providing the relevant result_ids in the body of your request. The response will tell you whether the batch of updates has either been successful or failed.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class PatchResultsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var updateMultipleResultPayload = new UpdateMultipleResultResponse(); // UpdateMultipleResultResponse | Payload for update multiple Result request (optional) 

            try
            {
                UpdateMultipleResultResponse result = apiInstance.PatchResults(updateMultipleResultPayload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.PatchResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateMultipleResultPayload** | [**UpdateMultipleResultResponse**](UpdateMultipleResultResponse.md)| Payload for update multiple Result request | [optional] 

### Return type

[**UpdateMultipleResultResponse**](UpdateMultipleResultResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchresultsresultid"></a>
# **PatchResultsResultId**
> Result PatchResultsResultId (string resultId, Result updateResultPayload = null)



Once a result has been created, it can be updated on the Platform by passing the required field values in the request body. A list of the fields that were changed are returned in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class PatchResultsResultIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var resultId = resultId_example;  // string | ID of the Result as an Integer
            var updateResultPayload = new Result(); // Result | Payload for update Result request (optional) 

            try
            {
                Result result = apiInstance.PatchResultsResultId(resultId, updateResultPayload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.PatchResultsResultId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resultId** | **string**| ID of the Result as an Integer | 
 **updateResultPayload** | [**Result**](Result.md)| Payload for update Result request | [optional] 

### Return type

[**Result**](Result.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

