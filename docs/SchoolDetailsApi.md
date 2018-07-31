# assembly-client-dotnet.Api.SchoolDetailsApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSchoolDetails**](SchoolDetailsApi.md#getschooldetails) | **GET** /school_details | 


<a name="getschooldetails"></a>
# **GetSchoolDetails**
> SchoolDetails GetSchoolDetails ()



Returns details for the school associated with the provided access_token.

### Example
```csharp
using System;
using System.Diagnostics;
using assembly-client-dotnet.Api;
using assembly-client-dotnet.Client;
using assembly-client-dotnet.Model;

namespace Example
{
    public class GetSchoolDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolDetailsApi();

            try
            {
                SchoolDetails result = apiInstance.GetSchoolDetails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolDetailsApi.GetSchoolDetails: " + e.Message );
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

