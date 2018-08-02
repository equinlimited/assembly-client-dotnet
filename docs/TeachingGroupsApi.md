# AssemblyClient.Api.TeachingGroupsApi

All URIs are relative to *http://api-sandbox.lvh.me:3020*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeachingGroup**](TeachingGroupsApi.md#teachinggroup) | **GET** /teaching_groups/{id} | View a Teaching Group
[**TeachingGroupStudents**](TeachingGroupsApi.md#teachinggroupstudents) | **GET** /teaching_groups/{id}/students | List Students for Teaching Group
[**TeachingGroups**](TeachingGroupsApi.md#teachinggroups) | **GET** /teaching_groups | List Teaching Groups


<a name="teachinggroup"></a>
# **TeachingGroup**
> TeachingGroup TeachingGroup (int? id, DateTime? date = null, int? academicYearId = null)

View a Teaching Group

Returns a single teaching group whose ID matches the provided group_id. Additionally includes a list of all the student and supervisor identifiers that have ever been enrolled in the group.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class TeachingGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TeachingGroupsApi();
            var id = 56;  // int? | id of the entity
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | returns results for a specific date (optional) 
            var academicYearId = 56;  // int? | returns all groups and group memberships from the specified academic year (optional) 

            try
            {
                // View a Teaching Group
                TeachingGroup result = apiInstance.TeachingGroup(id, date, academicYearId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeachingGroupsApi.TeachingGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the entity | 
 **date** | **DateTime?**| returns results for a specific date | [optional] 
 **academicYearId** | **int?**| returns all groups and group memberships from the specified academic year | [optional] 

### Return type

[**TeachingGroup**](TeachingGroup.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teachinggroupstudents"></a>
# **TeachingGroupStudents**
> StudentList TeachingGroupStudents (DateTime? ifModifiedSince = null, bool? demographics = null, bool? contacts = null, bool? senNeeds = null, bool? addresses = null, bool? care = null, bool? everInCare = null, bool? languages = null, bool? photo = null)

List Students for Teaching Group

Returns a list of all the students that are present in the teaching group identified by group_id.  **Note:** Note the `If-Modified-Since` header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class TeachingGroupStudentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TeachingGroupsApi();
            var ifModifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional) 
            var demographics = new bool?(); // bool? | include demographics data (optional) 
            var contacts = new bool?(); // bool? | include contacts data (optional) 
            var senNeeds = new bool?(); // bool? | include SEN needs data (optional) 
            var addresses = new bool?(); // bool? | include student address data (optional) 
            var care = new bool?(); // bool? | include student care data (you must also supply the demographics parameter) (optional) 
            var everInCare = new bool?(); // bool? | include whether the student has ever been in care (you must also supply the demographics parameter) (optional) 
            var languages = new bool?(); // bool? | include student language data (optional) 
            var photo = new bool?(); // bool? | include student photo data (optional) 

            try
            {
                // List Students for Teaching Group
                StudentList result = apiInstance.TeachingGroupStudents(ifModifiedSince, demographics, contacts, senNeeds, addresses, care, everInCare, languages, photo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeachingGroupsApi.TeachingGroupStudents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ifModifiedSince** | **DateTime?**| If-Modified-Since is optional (see the page on Conditional Requests for more details). | [optional] 
 **demographics** | [**bool?**](bool?.md)| include demographics data | [optional] 
 **contacts** | [**bool?**](bool?.md)| include contacts data | [optional] 
 **senNeeds** | [**bool?**](bool?.md)| include SEN needs data | [optional] 
 **addresses** | [**bool?**](bool?.md)| include student address data | [optional] 
 **care** | [**bool?**](bool?.md)| include student care data (you must also supply the demographics parameter) | [optional] 
 **everInCare** | [**bool?**](bool?.md)| include whether the student has ever been in care (you must also supply the demographics parameter) | [optional] 
 **languages** | [**bool?**](bool?.md)| include student language data | [optional] 
 **photo** | [**bool?**](bool?.md)| include student photo data | [optional] 

### Return type

[**StudentList**](StudentList.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teachinggroups"></a>
# **TeachingGroups**
> TeachingGroupList TeachingGroups (DateTime? ifModifiedSince = null, string subjectCode = null, int? yearCode = null, DateTime? date = null, int? academicYearId = null, int? perPage = null, int? page = null)

List Teaching Groups

Returns a list of teaching groups that match the given set of filters.  If a date parameter is provided then the list of groups returned is filtered to only those where the provided date falls between the groups start_date and end_date. Additionally when a date parameter is provided student_ids and supervior_ids are restricted to only those students who were enrolled in the group on the given date.  **Note:** Note the `If-Modified-Since` header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class TeachingGroupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TeachingGroupsApi();
            var ifModifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional) 
            var subjectCode = subjectCode_example;  // string | filter by subject (optional) 
            var yearCode = 56;  // int? | filter by school year (cannot be supplied at the same time as the students parameter) (optional) 
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | returns results for a specific date (optional) 
            var academicYearId = 56;  // int? | returns all groups and group memberships from the specified academic year (optional) 
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)

            try
            {
                // List Teaching Groups
                TeachingGroupList result = apiInstance.TeachingGroups(ifModifiedSince, subjectCode, yearCode, date, academicYearId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeachingGroupsApi.TeachingGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ifModifiedSince** | **DateTime?**| If-Modified-Since is optional (see the page on Conditional Requests for more details). | [optional] 
 **subjectCode** | **string**| filter by subject | [optional] 
 **yearCode** | **int?**| filter by school year (cannot be supplied at the same time as the students parameter) | [optional] 
 **date** | **DateTime?**| returns results for a specific date | [optional] 
 **academicYearId** | **int?**| returns all groups and group memberships from the specified academic year | [optional] 
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **page** | **int?**| Page number to return | [optional] [default to 1]

### Return type

[**TeachingGroupList**](TeachingGroupList.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

