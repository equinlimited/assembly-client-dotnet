# AssemblyClient.Api.StaffMembersApi

All URIs are relative to *http://api-sandbox.lvh.me:3020*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StaffMember**](StaffMembersApi.md#staffmember) | **GET** /staff_members/{id} | View a Staff Member
[**StaffMembers**](StaffMembersApi.md#staffmembers) | **GET** /staff_members | List Staff Members


<a name="staffmember"></a>
# **StaffMember**
> StaffMember StaffMember (int? id, bool? demographics = null, bool? qualifications = null)

View a Staff Member

Returns an individual staff member record for the given ID.  **Note:** Note the `If-Modified-Since` header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class StaffMemberExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StaffMembersApi();
            var id = 56;  // int? | id of the entity
            var demographics = true;  // bool? | include demographics data (optional) 
            var qualifications = true;  // bool? | include HLTA status, QT status, QT route and previous degree information (requires `staff_members.qualifications` scope) (optional) 

            try
            {
                // View a Staff Member
                StaffMember result = apiInstance.StaffMember(id, demographics, qualifications);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffMembersApi.StaffMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of the entity | 
 **demographics** | **bool?**| include demographics data | [optional] 
 **qualifications** | **bool?**| include HLTA status, QT status, QT route and previous degree information (requires &#x60;staff_members.qualifications&#x60; scope) | [optional] 

### Return type

[**StaffMember**](StaffMember.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="staffmembers"></a>
# **StaffMembers**
> StaffMemberList StaffMembers (bool? teachersOnly = null, bool? demographics = null, bool? qualifications = null, DateTime? ifModifiedSince = null, int? perPage = null, int? page = null)

List Staff Members

Returns a list of staff members for the school accociated with the provided `access_token`.  **Note:** Note the `If-Modified-Since` header is optional (see the page on [Conditional Requests](/api#conditional-requests) for more details). 

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class StaffMembersExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StaffMembersApi();
            var teachersOnly = true;  // bool? | return only staff who are teachers (optional) 
            var demographics = true;  // bool? | include demographics data (optional) 
            var qualifications = true;  // bool? | include HLTA status, QT status, QT route and previous degree information (requires `staff_members.qualifications` scope) (optional) 
            var ifModifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional) 
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)

            try
            {
                // List Staff Members
                StaffMemberList result = apiInstance.StaffMembers(teachersOnly, demographics, qualifications, ifModifiedSince, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffMembersApi.StaffMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teachersOnly** | **bool?**| return only staff who are teachers | [optional] 
 **demographics** | **bool?**| include demographics data | [optional] 
 **qualifications** | **bool?**| include HLTA status, QT status, QT route and previous degree information (requires &#x60;staff_members.qualifications&#x60; scope) | [optional] 
 **ifModifiedSince** | **DateTime?**| If-Modified-Since is optional (see the page on Conditional Requests for more details). | [optional] 
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **page** | **int?**| Page number to return | [optional] [default to 1]

### Return type

[**StaffMemberList**](StaffMemberList.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

