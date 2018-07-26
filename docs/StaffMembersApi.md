# AssemblyClient.Api.StaffMembersApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStaffAbsences**](StaffMembersApi.md#getstaffabsences) | **GET** /staff_absences | 
[**GetStaffContracts**](StaffMembersApi.md#getstaffcontracts) | **GET** /staff_contracts | 
[**GetStaffContractsStaffMemberId**](StaffMembersApi.md#getstaffcontractsstaffmemberid) | **GET** /staff_contracts/{staff_member_id} | 
[**GetStaffMembers**](StaffMembersApi.md#getstaffmembers) | **GET** /staff_members | 
[**GetStaffMembersStaffMemberId**](StaffMembersApi.md#getstaffmembersstaffmemberid) | **GET** /staff_members/{staff_member_id} | 


<a name="getstaffabsences"></a>
# **GetStaffAbsences**
> StaffAbsenceList GetStaffAbsences (string startDate = null, string endDate = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of staff member absences for the school accociated with the provided access_token. A school level access token with the staff_members.absences scope is required to access staff member absence information.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetStaffAbsencesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffMembersApi();
            var startDate = startDate_example;  // string | The start date of the period to return data for (optional) 
            var endDate = endDate_example;  // string | The end date of the period to return data for (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                StaffAbsenceList result = apiInstance.GetStaffAbsences(startDate, endDate, page, perPage, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffMembersApi.GetStaffAbsences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| The start date of the period to return data for | [optional] 
 **endDate** | **string**| The end date of the period to return data for | [optional] 
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **ifModifiedSince** | **string**| Timestamp of the last response. | [optional] 

### Return type

[**StaffAbsenceList**](StaffAbsenceList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffcontracts"></a>
# **GetStaffContracts**
> StaffContractList GetStaffContracts (string date = null, bool? roles = null, bool? salaries = null, bool? allowances = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of staff member contracts for the school accociated with the provided access_token. A school level access token with the staff_members.contracts scope is required to access staff member contract information.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetStaffContractsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffMembersApi();
            var date = date_example;  // string | Filter for a specific date (optional) 
            var roles = true;  // bool? | Return roles information along with this object (optional)  (default to false)
            var salaries = true;  // bool? | Return salary information along with this object (optional)  (default to false)
            var allowances = true;  // bool? | Return allowances information along with this object (optional)  (default to false)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                StaffContractList result = apiInstance.GetStaffContracts(date, roles, salaries, allowances, page, perPage, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffMembersApi.GetStaffContracts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **string**| Filter for a specific date | [optional] 
 **roles** | **bool?**| Return roles information along with this object | [optional] [default to false]
 **salaries** | **bool?**| Return salary information along with this object | [optional] [default to false]
 **allowances** | **bool?**| Return allowances information along with this object | [optional] [default to false]
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **ifModifiedSince** | **string**| Timestamp of the last response. | [optional] 

### Return type

[**StaffContractList**](StaffContractList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffcontractsstaffmemberid"></a>
# **GetStaffContractsStaffMemberId**
> StaffContractList GetStaffContractsStaffMemberId (string staffMemberId, string date = null, bool? roles = null, bool? salaries = null, bool? allowances = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of staff member contracts for the school accociated with the provided access_token. A school level access token with the staff_members.contracts scope is required to access staff member contract information.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetStaffContractsStaffMemberIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffMembersApi();
            var staffMemberId = staffMemberId_example;  // string | ID of the Staff Member as an Integer
            var date = date_example;  // string | Filter for a specific date (optional) 
            var roles = true;  // bool? | Return roles information along with this object (optional)  (default to false)
            var salaries = true;  // bool? | Return salary information along with this object (optional)  (default to false)
            var allowances = true;  // bool? | Return allowances information along with this object (optional)  (default to false)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                StaffContractList result = apiInstance.GetStaffContractsStaffMemberId(staffMemberId, date, roles, salaries, allowances, page, perPage, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffMembersApi.GetStaffContractsStaffMemberId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffMemberId** | **string**| ID of the Staff Member as an Integer | 
 **date** | **string**| Filter for a specific date | [optional] 
 **roles** | **bool?**| Return roles information along with this object | [optional] [default to false]
 **salaries** | **bool?**| Return salary information along with this object | [optional] [default to false]
 **allowances** | **bool?**| Return allowances information along with this object | [optional] [default to false]
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **ifModifiedSince** | **string**| Timestamp of the last response. | [optional] 

### Return type

[**StaffContractList**](StaffContractList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffmembers"></a>
# **GetStaffMembers**
> StaffMemberList GetStaffMembers (bool? teachersOnly = null, bool? demographics = null, bool? qualifications = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of staff members for the school accociated with the provided access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetStaffMembersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffMembersApi();
            var teachersOnly = true;  // bool? | Return only staff who are teachers (optional)  (default to false)
            var demographics = true;  // bool? | Return demographic information along with the person (requires appropriate scope) (optional)  (default to false)
            var qualifications = true;  // bool? | Include HLTA status, QT status, QT route and previous degree information (requires appropriate scope) (optional)  (default to false)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                StaffMemberList result = apiInstance.GetStaffMembers(teachersOnly, demographics, qualifications, page, perPage, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffMembersApi.GetStaffMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teachersOnly** | **bool?**| Return only staff who are teachers | [optional] [default to false]
 **demographics** | **bool?**| Return demographic information along with the person (requires appropriate scope) | [optional] [default to false]
 **qualifications** | **bool?**| Include HLTA status, QT status, QT route and previous degree information (requires appropriate scope) | [optional] [default to false]
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **ifModifiedSince** | **string**| Timestamp of the last response. | [optional] 

### Return type

[**StaffMemberList**](StaffMemberList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffmembersstaffmemberid"></a>
# **GetStaffMembersStaffMemberId**
> StaffMember GetStaffMembersStaffMemberId (string staffMemberId, bool? demographics = null, bool? qualifications = null, string ifModifiedSince = null)



Returns an individual staff member record for the given ID.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetStaffMembersStaffMemberIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffMembersApi();
            var staffMemberId = staffMemberId_example;  // string | ID of the Staff Member as an Integer
            var demographics = true;  // bool? | Return demographic information along with the person (requires appropriate scope) (optional)  (default to false)
            var qualifications = true;  // bool? | Include HLTA status, QT status, QT route and previous degree information (requires appropriate scope) (optional)  (default to false)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                StaffMember result = apiInstance.GetStaffMembersStaffMemberId(staffMemberId, demographics, qualifications, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffMembersApi.GetStaffMembersStaffMemberId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffMemberId** | **string**| ID of the Staff Member as an Integer | 
 **demographics** | **bool?**| Return demographic information along with the person (requires appropriate scope) | [optional] [default to false]
 **qualifications** | **bool?**| Include HLTA status, QT status, QT route and previous degree information (requires appropriate scope) | [optional] [default to false]
 **ifModifiedSince** | **string**| Timestamp of the last response. | [optional] 

### Return type

[**StaffMember**](StaffMember.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

