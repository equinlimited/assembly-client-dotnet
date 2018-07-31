# assembly-client-dotnet.Api.TeachingGroupsApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTeachingGroups**](TeachingGroupsApi.md#getteachinggroups) | **GET** /teaching_groups | 
[**GetTeachingGroupsGroupId**](TeachingGroupsApi.md#getteachinggroupsgroupid) | **GET** /teaching_groups/{group_id} | 
[**GetTeachingGroupsGroupIdStudents**](TeachingGroupsApi.md#getteachinggroupsgroupidstudents) | **GET** /teaching_groups/{group_id}/students | 


<a name="getteachinggroups"></a>
# **GetTeachingGroups**
> TeachingGroupList GetTeachingGroups (string subjectCode = null, string yearCode = null, string date = null, int? academicYearId = null, int? page = null, int? perPage = null)



Returns a list of teaching groups that match the given set of filters. If a date parameter is provided then the list of groups returned is filtered to only those where the provided date falls between the groups start_date and end_date. Additionally when a date parameter is provided student_ids and supervior_ids are restricted to only those students who were enrolled in the group on the given date.

### Example
```csharp
using System;
using System.Diagnostics;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace Example
{
    public class GetTeachingGroupsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeachingGroupsApi();
            var subjectCode = subjectCode_example;  // string | Filter by subject (optional) 
            var yearCode = yearCode_example;  // string | Filter by a specific NC year code (optional) 
            var date = date_example;  // string | Filter for a specific date (optional) 
            var academicYearId = 56;  // int? | Filter based on the specified academic year (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)

            try
            {
                TeachingGroupList result = apiInstance.GetTeachingGroups(subjectCode, yearCode, date, academicYearId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeachingGroupsApi.GetTeachingGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subjectCode** | **string**| Filter by subject | [optional] 
 **yearCode** | **string**| Filter by a specific NC year code | [optional] 
 **date** | **string**| Filter for a specific date | [optional] 
 **academicYearId** | **int?**| Filter based on the specified academic year | [optional] 
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]

### Return type

[**TeachingGroupList**](TeachingGroupList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteachinggroupsgroupid"></a>
# **GetTeachingGroupsGroupId**
> TeachingGroup GetTeachingGroupsGroupId (string groupId, string date = null, int? academicYearId = null)



Returns a single teaching group whose ID matches the provided group_id. Additionally includes a list of all the student and supervisor identifiers that have ever been enrolled in the group.

### Example
```csharp
using System;
using System.Diagnostics;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace Example
{
    public class GetTeachingGroupsGroupIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeachingGroupsApi();
            var groupId = groupId_example;  // string | ID of the Year Group as an Integer
            var date = date_example;  // string | Filter for a specific date (optional) 
            var academicYearId = 56;  // int? | Filter based on the specified academic year (optional) 

            try
            {
                TeachingGroup result = apiInstance.GetTeachingGroupsGroupId(groupId, date, academicYearId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeachingGroupsApi.GetTeachingGroupsGroupId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| ID of the Year Group as an Integer | 
 **date** | **string**| Filter for a specific date | [optional] 
 **academicYearId** | **int?**| Filter based on the specified academic year | [optional] 

### Return type

[**TeachingGroup**](TeachingGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteachinggroupsgroupidstudents"></a>
# **GetTeachingGroupsGroupIdStudents**
> StudentList GetTeachingGroupsGroupIdStudents (string groupId, string yearCode = null, string date = null, int? academicYearId = null, bool? demographics = null, bool? care = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of all the students that are present in the teaching group identified by group_id.

### Example
```csharp
using System;
using System.Diagnostics;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace Example
{
    public class GetTeachingGroupsGroupIdStudentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeachingGroupsApi();
            var groupId = groupId_example;  // string | ID of the Year Group as an Integer
            var yearCode = yearCode_example;  // string | Filter by a specific NC year code (optional) 
            var date = date_example;  // string | Filter for a specific date (optional) 
            var academicYearId = 56;  // int? | Filter based on the specified academic year (optional) 
            var demographics = true;  // bool? | Return demographic information along with the person (requires appropriate scope) (optional)  (default to false)
            var care = true;  // bool? | Return care information along with this object, depends on inclusion of demographics (optional)  (default to false)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                StudentList result = apiInstance.GetTeachingGroupsGroupIdStudents(groupId, yearCode, date, academicYearId, demographics, care, page, perPage, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeachingGroupsApi.GetTeachingGroupsGroupIdStudents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| ID of the Year Group as an Integer | 
 **yearCode** | **string**| Filter by a specific NC year code | [optional] 
 **date** | **string**| Filter for a specific date | [optional] 
 **academicYearId** | **int?**| Filter based on the specified academic year | [optional] 
 **demographics** | **bool?**| Return demographic information along with the person (requires appropriate scope) | [optional] [default to false]
 **care** | **bool?**| Return care information along with this object, depends on inclusion of demographics | [optional] [default to false]
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **ifModifiedSince** | **string**| Timestamp of the last response. | [optional] 

### Return type

[**StudentList**](StudentList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

