# AssemblyClient.Api.ContactsApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Contacts**](ContactsApi.md#contacts) | **GET** /contacts | 


<a name="contacts"></a>
# **Contacts**
> ContactList Contacts (int? studentId = null, int? page = null, int? perPage = null)



Returns a list of contacts that match the given set of filters.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class ContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var studentId = 56;  // int? | ID of the Student as an Integer (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)

            try
            {
                ContactList result = apiInstance.Contacts(studentId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.Contacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentId** | **int?**| ID of the Student as an Integer | [optional] 
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]

### Return type

[**ContactList**](ContactList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

