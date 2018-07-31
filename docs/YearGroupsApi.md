# assembly-client-dotnet.Api.YearGroupsApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**YearGroups**](YearGroupsApi.md#yeargroups) | **GET** /year_groups | 
[**YearGroupsGroupId**](YearGroupsApi.md#yeargroupsgroupid) | **GET** /year_groups/{group_id} | 
[**YearGroupsGroupIdStudents**](YearGroupsApi.md#yeargroupsgroupidstudents) | **GET** /year_groups/{group_id}/students | 


<a name="yeargroups"></a>
# **YearGroups**
> YearGroupList YearGroups (string yearCode = null, string date = null, int? academicYearId = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of year groups that match the given set of filters. The default behaviour is to return the year groups for the school's current academic year.

### Example
```csharp
using System;
using System.Diagnostics;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace Example
{
    public class YearGroupsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new YearGroupsApi();
            var yearCode = yearCode_example;  // string | Filter by a specific NC year code (optional) 
            var date = date_example;  // string | Filter for a specific date (optional) 
            var academicYearId = 56;  // int? | Filter based on the specified academic year (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                YearGroupList result = apiInstance.YearGroups(yearCode, date, academicYearId, page, perPage, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling YearGroupsApi.YearGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **yearCode** | **string**| Filter by a specific NC year code | [optional] 
 **date** | **string**| Filter for a specific date | [optional] 
 **academicYearId** | **int?**| Filter based on the specified academic year | [optional] 
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **ifModifiedSince** | **string**| Timestamp of the last response. | [optional] 

### Return type

[**YearGroupList**](YearGroupList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="yeargroupsgroupid"></a>
# **YearGroupsGroupId**
> YearGroup YearGroupsGroupId (string groupId, string date = null, int? academicYearId = null)



Returns a single year group whose code matches the provided year_code. Additionally includes a list of all the student identifiers that are present in the group.

### Example
```csharp
using System;
using System.Diagnostics;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace Example
{
    public class YearGroupsGroupIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new YearGroupsApi();
            var groupId = groupId_example;  // string | ID of the Year Group as an Integer
            var date = date_example;  // string | Filter for a specific date (optional) 
            var academicYearId = 56;  // int? | Filter based on the specified academic year (optional) 

            try
            {
                YearGroup result = apiInstance.YearGroupsGroupId(groupId, date, academicYearId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling YearGroupsApi.YearGroupsGroupId: " + e.Message );
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

[**YearGroup**](YearGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="yeargroupsgroupidstudents"></a>
# **YearGroupsGroupIdStudents**
> StudentList YearGroupsGroupIdStudents (string groupId, string date = null, int? academicYearId = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of all the students that are present in the year group identified by year_code.

### Example
```csharp
using System;
using System.Diagnostics;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace Example
{
    public class YearGroupsGroupIdStudentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new YearGroupsApi();
            var groupId = groupId_example;  // string | ID of the Year Group as an Integer
            var date = date_example;  // string | Filter for a specific date (optional) 
            var academicYearId = 56;  // int? | Filter based on the specified academic year (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                StudentList result = apiInstance.YearGroupsGroupIdStudents(groupId, date, academicYearId, page, perPage, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling YearGroupsApi.YearGroupsGroupIdStudents: " + e.Message );
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

