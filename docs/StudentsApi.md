# AssemblyClient.Api.StudentsApi

All URIs are relative to *http://api-sandbox.lvh.me:3020*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LeftStudents**](StudentsApi.md#leftstudents) | **GET** /students/left | List Left Students
[**Student**](StudentsApi.md#student) | **GET** /students/{id} | View a Student
[**Students**](StudentsApi.md#students) | **GET** /students | List Students


<a name="leftstudents"></a>
# **LeftStudents**
> StudentList LeftStudents (DateTime? ifModifiedSince = null, int? perPage = null, int? page = null)

List Left Students

Returns a list of students who have left the school.<br><br>**Note:** This will include any students who have left the school during the current academic year. If the school has been connected to Assembly for more than one academic year, all left students will be returned. The `If-Modified-Since` header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details).

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class LeftStudentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StudentsApi();
            var ifModifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional) 
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)

            try
            {
                // List Left Students
                StudentList result = apiInstance.LeftStudents(ifModifiedSince, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentsApi.LeftStudents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ifModifiedSince** | **DateTime?**| If-Modified-Since is optional (see the page on Conditional Requests for more details). | [optional] 
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **page** | **int?**| Page number to return | [optional] [default to 1]

### Return type

[**StudentList**](StudentList.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="student"></a>
# **Student**
> Student Student (int? id, bool? demographics = null, bool? contacts = null, bool? senNeeds = null, bool? addresses = null, bool? care = null, bool? everInCare = null, bool? languages = null, bool? photo = null)

View a Student

Returns an individual student record for the given ID.  **Note:** the response shown includes student demographics, contacts, student SEN needs, student addresses, photo and student care data but these will only be present if you have permission to access it and pass `demographics`, `contacts`, `sen_needs`, `addresses`, `photo`, `care` and `ever_in_care` respectively  **Note:** Note the `If-Modified-Since` header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details).  ### Photo Notes When requesting photo information the response includes a `photo.url` property, this URL should be treated as confidential and used to download the students photo to your storage system of choice. The URL is *not designed for hotlinking directly in the browser* for end users. URLs are signed and only valid for 1 hour after which time you will receive a 400 error.  Once downloaded to avoid repeatedly syncing unchanged photos you should code your application to compare the `photo.hash` property to detect changes in student photos since your last sync, it is guaranteed that changes in a photo will change the hash, however the hash is only intended to be used to detect photo changes and is not guaranteed to match a checksum of the files contents.  Photos are currently provided on an \"as is\" basis straight from the source MIS, this means the format, quality, metadata and dimensions are not guaranteed. We reserve the right to normalise this data in the future but your application should be resistant to differing photo formats. 

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class StudentExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StudentsApi();
            var id = 56;  // int? | id of the entity
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
                // View a Student
                Student result = apiInstance.Student(id, demographics, contacts, senNeeds, addresses, care, everInCare, languages, photo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentsApi.Student: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the entity | 
 **demographics** | **bool?**| include demographics data | [optional] [default to false]
 **contacts** | **bool?**| include contacts data | [optional] [default to false]
 **senNeeds** | **bool?**| include SEN needs data | [optional] [default to false]
 **addresses** | **bool?**| include student address data | [optional] [default to false]
 **care** | **bool?**| include student care data (you must also supply the demographics parameter) | [optional] [default to false]
 **everInCare** | **bool?**| include whether the student has ever been in care (you must also supply the demographics parameter) | [optional] [default to false]
 **languages** | **bool?**| include student language data | [optional] [default to false]
 **photo** | **bool?**| include student photo data | [optional] [default to false]

### Return type

[**Student**](Student.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="students"></a>
# **Students**
> StudentList Students (DateTime? ifModifiedSince = null, List<int?> students = null, DateTime? date = null, int? yearCode = null, bool? demographics = null, bool? contacts = null, bool? senNeeds = null, bool? addresses = null, bool? care = null, bool? everInCare = null, bool? languages = null, bool? photo = null, int? perPage = null, int? page = null)

List Students

Returns a list of students for the school associated with the provided `access_token.` **Note:** the `If-Modified-Since` header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class StudentsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StudentsApi();
            var ifModifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional) 
            var students = new List<int?>(); // List<int?> | ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded). (optional) 
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | returns results for a specific date (optional) 
            var yearCode = 56;  // int? | filter by school year (cannot be supplied at the same time as the students parameter) (optional) 
            var demographics = true;  // bool? | include demographics data (optional)  (default to false)
            var contacts = true;  // bool? | include contacts data (optional)  (default to false)
            var senNeeds = true;  // bool? | include SEN needs data (optional)  (default to false)
            var addresses = true;  // bool? | include student address data (optional)  (default to false)
            var care = true;  // bool? | include student care data (you must also supply the demographics parameter) (optional)  (default to false)
            var everInCare = true;  // bool? | include whether the student has ever been in care (you must also supply the demographics parameter) (optional)  (default to false)
            var languages = true;  // bool? | include student language data (optional)  (default to false)
            var photo = true;  // bool? | include student photo data (optional)  (default to false)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)

            try
            {
                // List Students
                StudentList result = apiInstance.Students(ifModifiedSince, students, date, yearCode, demographics, contacts, senNeeds, addresses, care, everInCare, languages, photo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentsApi.Students: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ifModifiedSince** | **DateTime?**| If-Modified-Since is optional (see the page on Conditional Requests for more details). | [optional] 
 **students** | [**List&lt;int?&gt;**](int?.md)| ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded). | [optional] 
 **date** | **DateTime?**| returns results for a specific date | [optional] 
 **yearCode** | **int?**| filter by school year (cannot be supplied at the same time as the students parameter) | [optional] 
 **demographics** | **bool?**| include demographics data | [optional] [default to false]
 **contacts** | **bool?**| include contacts data | [optional] [default to false]
 **senNeeds** | **bool?**| include SEN needs data | [optional] [default to false]
 **addresses** | **bool?**| include student address data | [optional] [default to false]
 **care** | **bool?**| include student care data (you must also supply the demographics parameter) | [optional] [default to false]
 **everInCare** | **bool?**| include whether the student has ever been in care (you must also supply the demographics parameter) | [optional] [default to false]
 **languages** | **bool?**| include student language data | [optional] [default to false]
 **photo** | **bool?**| include student photo data | [optional] [default to false]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **page** | **int?**| Page number to return | [optional] [default to 1]

### Return type

[**StudentList**](StudentList.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

