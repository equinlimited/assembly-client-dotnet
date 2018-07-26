# AssemblyClient.Model.TeachingGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_object** | **string** | Object type | [optional] 
**id** | **int?** | Internal stable ID given to all teaching groups in the Platform | [optional] 
**name** | **string** | Name of teaching group | [optional] 
**start_date** | **DateTime?** | The start date of the teaching group | [optional] 
**end_date** | **DateTime?** | The end date of the teaching group | [optional] 
**supervisor_ids** | **List&lt;int?&gt;** | The IDs of supervisors associated with the teaching group | [optional] 
**student_ids** | **List&lt;int?&gt;** | The IDs of students associated with the teaching group | [optional] 
**subject** | [**TeachingGroupSubject**](TeachingGroupSubject.md) |  | [optional] 
**mis_level** | **string** | The official examination or assessment &#39;level&#39; of the teaching group taken directly from the MIS | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

