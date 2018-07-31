# AssemblyClient.Api.SchoolDetailsApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SchoolDetails**](SchoolDetailsApi.md#schooldetails) | **GET** /school_details | 


<a name="schooldetails"></a>
# **SchoolDetails**
> SchoolDetails SchoolDetails ()



Returns details for the school associated with the provided access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class SchoolDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolDetailsApi();

            try
            {
                SchoolDetails result = apiInstance.SchoolDetails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolDetailsApi.SchoolDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SchoolDetails**](SchoolDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

