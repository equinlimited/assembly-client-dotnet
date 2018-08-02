# AssemblyClient.Api.StaffContractsApi

All URIs are relative to *http://api-sandbox.lvh.me:3020*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StaffContracts**](StaffContractsApi.md#staffcontracts) | **GET** /staff_contracts | List Staff Contracts


<a name="staffcontracts"></a>
# **StaffContracts**
> StaffMemberList StaffContracts (int? staffMemberId = null, bool? date = null, bool? roles = null, bool? salaries = null, bool? allowances = null, DateTime? ifModifiedSince = null, int? perPage = null, int? page = null)

List Staff Contracts

Returns a list of staff member contracts for the school accociated with the provided `access_token`. A school level access token with the `staff_members.contracts` scope is required to access staff member contract information.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class StaffContractsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StaffContractsApi();
            var staffMemberId = 56;  // int? | show only absences fot the specified staff member (optional) 
            var date = true;  // bool? | returns results for a specific date (optional) 
            var roles = true;  // bool? | return roles information along with a staff contract (optional) 
            var salaries = true;  // bool? | return salaries information along with a staff contract (requires staff_members.salaries scope for full information - only the hours_per_week, fte and weeks_per_year fields are shown without it) (optional) 
            var allowances = true;  // bool? | return allowances information along with a staff contract (requires staff_members.salaries scope) (optional) 
            var ifModifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | If-Modified-Since is optional (see the page on Conditional Requests for more details). (optional) 
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var page = 56;  // int? | Page number to return (optional)  (default to 1)

            try
            {
                // List Staff Contracts
                StaffMemberList result = apiInstance.StaffContracts(staffMemberId, date, roles, salaries, allowances, ifModifiedSince, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffContractsApi.StaffContracts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffMemberId** | **int?**| show only absences fot the specified staff member | [optional] 
 **date** | **bool?**| returns results for a specific date | [optional] 
 **roles** | **bool?**| return roles information along with a staff contract | [optional] 
 **salaries** | **bool?**| return salaries information along with a staff contract (requires staff_members.salaries scope for full information - only the hours_per_week, fte and weeks_per_year fields are shown without it) | [optional] 
 **allowances** | **bool?**| return allowances information along with a staff contract (requires staff_members.salaries scope) | [optional] 
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

