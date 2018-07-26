# AssemblyClient.Api.RegistrationGroupsApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRegistrationGroups**](RegistrationGroupsApi.md#getregistrationgroups) | **GET** /registration_groups | 
[**GetRegistrationGroupsGroupId**](RegistrationGroupsApi.md#getregistrationgroupsgroupid) | **GET** /registration_groups/{group_id} | 
[**GetRegistrationGroupsGroupIdStudents**](RegistrationGroupsApi.md#getregistrationgroupsgroupidstudents) | **GET** /registration_groups/{group_id}/students | 


<a name="getregistrationgroups"></a>
# **GetRegistrationGroups**
> RegistrationGroupList GetRegistrationGroups (string yearCode = null, string date = null, int? academicYearId = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of registration groups that match the given set of filters.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetRegistrationGroupsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationGroupsApi();
            var yearCode = yearCode_example;  // string | Filter by a specific NC year code (optional) 
            var date = date_example;  // string | Filter for a specific date (optional) 
            var academicYearId = 56;  // int? | Filter based on the specified academic year (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                RegistrationGroupList result = apiInstance.GetRegistrationGroups(yearCode, date, academicYearId, page, perPage, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationGroupsApi.GetRegistrationGroups: " + e.Message );
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

[**RegistrationGroupList**](RegistrationGroupList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationgroupsgroupid"></a>
# **GetRegistrationGroupsGroupId**
> RegistrationGroup GetRegistrationGroupsGroupId (string groupId, string date = null, int? academicYearId = null, string ifModifiedSince = null)



Returns a single registration group whose code matches the provided group_id. Additionally includes a list of all the student identifiers that are present in the group.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetRegistrationGroupsGroupIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationGroupsApi();
            var groupId = groupId_example;  // string | ID of the Year Group as an Integer
            var date = date_example;  // string | Filter for a specific date (optional) 
            var academicYearId = 56;  // int? | Filter based on the specified academic year (optional) 
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                RegistrationGroup result = apiInstance.GetRegistrationGroupsGroupId(groupId, date, academicYearId, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationGroupsApi.GetRegistrationGroupsGroupId: " + e.Message );
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
 **ifModifiedSince** | **string**| Timestamp of the last response. | [optional] 

### Return type

[**RegistrationGroup**](RegistrationGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistrationgroupsgroupidstudents"></a>
# **GetRegistrationGroupsGroupIdStudents**
> StudentList GetRegistrationGroupsGroupIdStudents (string groupId, string yearCode = null, string date = null, int? academicYearId = null, bool? demographics = null, bool? care = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of all the students that are present in the registration group identified by group_id.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetRegistrationGroupsGroupIdStudentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationGroupsApi();
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
                StudentList result = apiInstance.GetRegistrationGroupsGroupIdStudents(groupId, yearCode, date, academicYearId, demographics, care, page, perPage, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationGroupsApi.GetRegistrationGroupsGroupIdStudents: " + e.Message );
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

