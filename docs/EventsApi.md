# AssemblyClient.Api.EventsApi

All URIs are relative to *https://api-sandbox.assembly.education*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCalendarEvents**](EventsApi.md#getcalendarevents) | **GET** /calendar_events | 


<a name="getcalendarevents"></a>
# **GetCalendarEvents**
> CalendarEventList GetCalendarEvents (string eventType = null, int? page = null, int? perPage = null, string ifModifiedSince = null)



Returns a list of calendar events from the school calendar. We strongly recommend that you use an object type to filter the events that will be returned to you. Presently, with SIMS only support, we've exposed the raw types from the underlying MIS. As such, it's most likely that you'll mostly be interested in 'User' events. This category includes items such as staff meetings and school assembly times as you can see from the sample response below.

### Example
```csharp
using System;
using System.Diagnostics;
using AssemblyClient.Api;
using AssemblyClient.Client;
using AssemblyClient.Model;

namespace Example
{
    public class GetCalendarEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi();
            var eventType = eventType_example;  // string | Return a calendar object type from the underlying MIS (optional) 
            var page = 56;  // int? | Page number to return (optional)  (default to 1)
            var perPage = 56;  // int? | Number of results to return (optional)  (default to 100)
            var ifModifiedSince = ifModifiedSince_example;  // string | Timestamp of the last response. (optional) 

            try
            {
                CalendarEventList result = apiInstance.GetCalendarEvents(eventType, page, perPage, ifModifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.GetCalendarEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventType** | **string**| Return a calendar object type from the underlying MIS | [optional] 
 **page** | **int?**| Page number to return | [optional] [default to 1]
 **perPage** | **int?**| Number of results to return | [optional] [default to 100]
 **ifModifiedSince** | **string**| Timestamp of the last response. | [optional] 

### Return type

[**CalendarEventList**](CalendarEventList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.assembly+json; version=1

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

