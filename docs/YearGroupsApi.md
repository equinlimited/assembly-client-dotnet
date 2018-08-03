# AssemblyClient.Api.YearGroupsApi

All URIs are relative to *http://api-sandbox.lvh.me:3020*

Method | HTTP request | Description
------------- | ------------- | -------------
[**YearGroup**](YearGroupsApi.md#yeargroup) | **GET** /year_groups/{id} | View a Year Group
[**YearGroupStudents**](YearGroupsApi.md#yeargroupstudents) | **GET** /year_groups/{id}/students | List Students for Year Group
[**YearGroups**](YearGroupsApi.md#yeargroups) | **GET** /year_groups | List Year Groups


<a name="yeargroup"></a>
# **YearGroup**
> YearGroup YearGroup (int? id, DateTime? date = null, int? academicYearId = null)

View a Year Group

Returns a list of year groups that match the given set of filters.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class YearGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new YearGroupsApi();
            var id = 56;  // int? | id of the entity
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | returns results for a specific date (optional) 
            var academicYearId = 56;  // int? | returns all groups and group memberships from the specified academic year (optional) 

            try
            {
                // View a Year Group
                YearGroup result = apiInstance.YearGroup(id, date, academicYearId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling YearGroupsApi.YearGroup: " + e.Message );
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

[**YearGroup**](YearGroup.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="yeargroupstudents"></a>
# **YearGroupStudents**
> StudentList YearGroupStudents (int? id, DateTime? ifModifiedSince = null, DateTime? date = null, int? academicYearId = null, bool? demographics = null, bool? contacts = null, bool? senNeeds = null, bool? addresses = null, bool? care = null, bool? everInCare = null, bool? languages = null, bool? photo = null)

List Students for Year Group

Returns a list of all the students that are present in the year group identified by group_id.  **Note:** Note the `If-Modified-Since` header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class YearGroupStudentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new YearGroupsApi();
            var id = 56;  // int? | id of the entity
            var ifModifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional) 
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | returns results for a specific date (optional) 
            var academicYearId = 56;  // int? | returns all groups and group memberships from the specified academic year (optional) 
            var demographics = true;  // bool? | include demographics data (optional)  (default to false)
            var contacts = true;  // bool? | include contacts data (optional)  (default to false)
            var senNeeds = true;  // bool? | include SEN needs data (optional)  (default to false)
            var addresses = true;  // bool? | include student address data (optional)  (default to false)
            var care = true;  // bool? | include student care data (you must also supply the demographics parameter) (optional)  (default to false)
            var everInCare = true;  // bool? | include whether the student has ever been in care (you must also supply the demographics parameter) (optional)  (default to false)
            var languages = true;  // bool? | include student language data (optional)  (default to false)
            var photo = true;  // bool? | include student photo data (optional)  (default to false)

            try
            {
                // List Students for Year Group
                StudentList result = apiInstance.YearGroupStudents(id, ifModifiedSince, date, academicYearId, demographics, contacts, senNeeds, addresses, care, everInCare, languages, photo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling YearGroupsApi.YearGroupStudents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the entity | 
 **ifModifiedSince** | **DateTime?**| If-Modified-Since is optional (see the page on Conditional Requests for more details). | [optional] 
 **date** | **DateTime?**| returns results for a specific date | [optional] 
 **academicYearId** | **int?**| returns all groups and group memberships from the specified academic year | [optional] 
 **demographics** | **bool?**| include demographics data | [optional] [default to false]
 **contacts** | **bool?**| include contacts data | [optional] [default to false]
 **senNeeds** | **bool?**| include SEN needs data | [optional] [default to false]
 **addresses** | **bool?**| include student address data | [optional] [default to false]
 **care** | **bool?**| include student care data (you must also supply the demographics parameter) | [optional] [default to false]
 **everInCare** | **bool?**| include whether the student has ever been in care (you must also supply the demographics parameter) | [optional] [default to false]
 **languages** | **bool?**| include student language data | [optional] [default to false]
 **photo** | **bool?**| include student photo data | [optional] [default to false]

### Return type

[**StudentList**](StudentList.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="yeargroups"></a>
# **YearGroups**
> YearGroup YearGroups (DateTime? ifModifiedSince = null, int? yearCode = null, DateTime? date = null, int? academicYearId = null, int? perPage = null, int? page = null)

List Year Groups

Returns a list of year groups that match the given set of filters.  If a date parameter is provided then the list of groups returned is filtered to only those where the provided date falls between the groups start_date and end_date. Additionally when a date parameter is provided student_ids and supervior_ids are restricted to only those students who were enrolled in the group on the given date.  **Note:** Note the `If-Modified-Since` header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class YearGroupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new YearGroupsApi();
            var ifModifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional) 
            var yearCode = 56;  // int? | filter by school year (cannot be supplied at the same time as the students parameter) (optional) 
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | returns results for a specific date (optional) 
            var academicYearId = 56;  // int? | returns all groups and group memberships from the specified academic year (optional) 
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)

            try
            {
                // List Year Groups
                YearGroup result = apiInstance.YearGroups(ifModifiedSince, yearCode, date, academicYearId, perPage, page);
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
 **ifModifiedSince** | **DateTime?**| If-Modified-Since is optional (see the page on Conditional Requests for more details). | [optional] 
 **yearCode** | **int?**| filter by school year (cannot be supplied at the same time as the students parameter) | [optional] 
 **date** | **DateTime?**| returns results for a specific date | [optional] 
 **academicYearId** | **int?**| returns all groups and group memberships from the specified academic year | [optional] 
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **page** | **int?**| Page number to return | [optional] [default to 1]

### Return type

[**YearGroup**](YearGroup.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

