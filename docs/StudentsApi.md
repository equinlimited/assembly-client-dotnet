# assembly-client-dotnet.Api.StudentsApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Students**](StudentsApi.md#students) | **GET** /students | 
[**StudentsStudentId**](StudentsApi.md#studentsstudentid) | **GET** /students/{student_id} | 


<a name="students"></a>
# **Students**
> StudentList Students (string yearCode = null, string students = null, string date = null, bool? demographics = null, bool? contacts = null, bool? senNeeds = null, bool? addresses = null, bool? care = null, bool? languages = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of students for the school associated with the provided access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace Example
{
    public class StudentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentsApi();
            var yearCode = yearCode_example;  // string | Filter by a specific NC year code (optional) 
            var students = students_example;  // string | ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded). (optional) 
            var date = date_example;  // string | Filter for a specific date (optional) 
            var demographics = true;  // bool? | Return demographic information along with the person (requires appropriate scope) (optional)  (default to false)
            var contacts = true;  // bool? | Return contact information along with this object (optional)  (default to false)
            var senNeeds = true;  // bool? | Return Special Educational Need information along with this object (optional)  (default to false)
            var addresses = true;  // bool? | Return address information along with this object (optional)  (default to false)
            var care = true;  // bool? | Return care information along with this object, depends on inclusion of demographics (optional)  (default to false)
            var languages = true;  // bool? | Return language information along with this object (optional)  (default to false)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                StudentList result = apiInstance.Students(yearCode, students, date, demographics, contacts, senNeeds, addresses, care, languages, page, perPage, ifModifiedSince);
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
 **yearCode** | **string**| Filter by a specific NC year code | [optional] 
 **students** | **string**| ID(s) of the student(s) as an Integer. Multiple IDs can be separated with a space (so a + URL encoded). | [optional] 
 **date** | **string**| Filter for a specific date | [optional] 
 **demographics** | **bool?**| Return demographic information along with the person (requires appropriate scope) | [optional] [default to false]
 **contacts** | **bool?**| Return contact information along with this object | [optional] [default to false]
 **senNeeds** | **bool?**| Return Special Educational Need information along with this object | [optional] [default to false]
 **addresses** | **bool?**| Return address information along with this object | [optional] [default to false]
 **care** | **bool?**| Return care information along with this object, depends on inclusion of demographics | [optional] [default to false]
 **languages** | **bool?**| Return language information along with this object | [optional] [default to false]
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

<a name="studentsstudentid"></a>
# **StudentsStudentId**
> Student StudentsStudentId (string studentId, string date = null, bool? demographics = null, bool? contacts = null, bool? senNeeds = null, bool? addresses = null, bool? care = null, bool? languages = null, string ifModifiedSince = null)



Returns an individual student record for the given ID. Note: the response shown includes student demographics, contacts, student SEN needs, student addresses and student care data but these will only be present if you have permission to access it and pass demographics=true, contacts=true, sen_needs=true, addresses=true and care=true respectively

### Example
```csharp
using System;
using System.Diagnostics;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace Example
{
    public class StudentsStudentIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentsApi();
            var studentId = studentId_example;  // string | ID of the Student as an Integer
            var date = date_example;  // string | Filter for a specific date (optional) 
            var demographics = true;  // bool? | Return demographic information along with the person (requires appropriate scope) (optional)  (default to false)
            var contacts = true;  // bool? | Return contact information along with this object (optional)  (default to false)
            var senNeeds = true;  // bool? | Return Special Educational Need information along with this object (optional)  (default to false)
            var addresses = true;  // bool? | Return address information along with this object (optional)  (default to false)
            var care = true;  // bool? | Return care information along with this object, depends on inclusion of demographics (optional)  (default to false)
            var languages = true;  // bool? | Return language information along with this object (optional)  (default to false)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                Student result = apiInstance.StudentsStudentId(studentId, date, demographics, contacts, senNeeds, addresses, care, languages, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentsApi.StudentsStudentId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentId** | **string**| ID of the Student as an Integer | 
 **date** | **string**| Filter for a specific date | [optional] 
 **demographics** | **bool?**| Return demographic information along with the person (requires appropriate scope) | [optional] [default to false]
 **contacts** | **bool?**| Return contact information along with this object | [optional] [default to false]
 **senNeeds** | **bool?**| Return Special Educational Need information along with this object | [optional] [default to false]
 **addresses** | **bool?**| Return address information along with this object | [optional] [default to false]
 **care** | **bool?**| Return care information along with this object, depends on inclusion of demographics | [optional] [default to false]
 **languages** | **bool?**| Return language information along with this object | [optional] [default to false]
 **ifModifiedSince** | **string**| Timestamp of the last response. | [optional] 

### Return type

[**Student**](Student.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

