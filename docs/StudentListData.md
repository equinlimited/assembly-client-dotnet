# AssemblyClient.Model.StudentListData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | Object type | [optional] 
**Id** | **int?** | Internal stable ID given to students in the Platform | [optional] 
**FirstName** | **string** | The first name of the student | [optional] 
**LegalFirstName** | **string** | The legal first name of the student | [optional] 
**MiddleName** | **string** | The middle name of the student | [optional] 
**LastName** | **string** | The last name of the student | [optional] 
**LegalLastName** | **string** | The legal last name of the student | [optional] 
**FormerLastName** | **string** | The former last name of the student | [optional] 
**Dob** | **DateTime?** | The date of birth of the student | [optional] 
**YearCode** | **string** | The year group the student currently belongs to *Values*  |Value|Description| |- --|- --| |&#x60;N1&#x60;|Nursery first year| |&#x60;N2&#x60;|Nursery second year| |&#x60;R&#x60;|Reception| |&#x60;1&#x60;|Year 1| |&#x60;2&#x60;|Year 2| |&#x60;3&#x60;|Year 3| |&#x60;4&#x60;|Year 4| |&#x60;5&#x60;|Year 5| |&#x60;6&#x60;|Year 6| |&#x60;7&#x60;|Year 7| |&#x60;8&#x60;|Year 8| |&#x60;9&#x60;|Year 9| |&#x60;10&#x60;|Year 10| |&#x60;11&#x60;|Year 11| |&#x60;12&#x60;|Year 12| |&#x60;13&#x60;|Year 13|  | [optional] 
**Upn** | **string** | Unique Pupil Number (UPN) - a DfE-mandated 13-character code that identifies each pupil | [optional] 
**FormerUpn** | **string** | The previous UPN where a pupil has held another UPN whilst at a school | [optional] 
**MisId** | **string** | The ID of a student from the MIS | [optional] 
**Pan** | **string** | A student&#39;s &#39;Pupil Admission Number&#39;. This field is exposed in the front end of the MIS, and may be the same as mis_id | [optional] 
**StartDate** | **DateTime?** | Date when the student joined the school | [optional] 
**EndDate** | **DateTime?** | Date when the student left the school (this will default to 2079-06-06T23:59:00.000Z) | [optional] 
**EnrolmentStatus** | **string** | The enrolment status of the student | [optional] 
**Demographics** | [**StudentDemographics**](StudentDemographics.md) |  | [optional] 
**Contact** | [**List&lt;ContactListData&gt;**](ContactListData.md) | List of contact IDs for the student. | [optional] 
**Addresses** | [**StudentAddresses**](StudentAddresses.md) |  | [optional] 
**Languages** | [**StudentLanguages**](StudentLanguages.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

