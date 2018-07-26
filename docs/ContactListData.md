# AssemblyClient.Model.ContactListData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_object** | **string** | Object type | [optional] 
**id** | **int?** | Internal stable ID given to all contacts on the Platform | [optional] 
**first_name** | **string** | The first name of the contact | [optional] 
**middle_name** | **string** | The middle name of the contact | [optional] 
**last_name** | **string** | The last name of the contact | [optional] 
**gender** | **string** | The gender of the contact *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female|  | [optional] 
**title** | **string** | The title of the contact | [optional] 
**salutation** | **string** | The salutation for the contact | [optional] 
**emails** | [**List&lt;ContactEmails&gt;**](ContactEmails.md) | A list of emails for the contact | [optional] 
**telephone_numbers** | [**List&lt;ContactTelephoneNumbers&gt;**](ContactTelephoneNumbers.md) | A list of telephone numbers for the contact | [optional] 
**students** | [**List&lt;ContactStudents&gt;**](ContactStudents.md) | A list of student IDs that the contact is responsible for | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

