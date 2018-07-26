# assembly-client-dotnet.Model.StudentDemographics
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | Object type | [optional] 
**EthnicityCode** | **string** | A detailed, Dfe standardised way of categorising the ethnicity of a student | [optional] 
**EthnicityGroup** | **string** | A broader categorisation of ethnicity that is standardised across the country, with all ethnicity codes grouped in to 8 sections | [optional] 
**Gender** | **string** | The gender of the student *Values*  |Value|Description| |- --|- --| |&#x60;M&#x60;|Male| |&#x60;F&#x60;|Female|  | [optional] 
**InCare** | **bool?** | Looked after status - indicates whether the student is &#39;looked after&#39; by the local authority (this field will only be returned if &amp;demographics&#x3D;true and &amp;care&#x3D;true is included in your request) | [optional] 
**IsEal** | **bool?** | English as an Additional Language (EAL) - this field will be true for a student whose first language is not English | [optional] 
**IsFsm** | **bool?** | Free School Meals (FSM) - indicates if the student is eligible for free school meals | [optional] 
**FsmReviewDate** | **DateTime?** | Free school meal review date -Review date for pupil&#39;s free school meal eligibility | [optional] 
**IsPp** | **bool?** | Pupil Premium (PP) - schools receive extra funding for students who qualify as Pupil Premium. The includes any student who has qualified for Free School Meals (FSM) in the last 6 years, and any student in local-authority care | [optional] 
**SenCategory** | **string** | Special Education Need (SEN) - indicates a student has learning difficulties and requires special education provision. *Values*  |Value|Description| |- --|- --| |&#x60;null&#x60;|Not eligable| |&#x60;N&#x60;|None| |&#x60;S&#x60;|Statement| |&#x60;E&#x60;|Education, Health and Care Plan| |&#x60;K&#x60;|SEN Support| |&#x60;A&#x60;|School Action (no longer valid)| |&#x60;P&#x60;|School Action Plus (no longer valid)|  | [optional] 
**SenNeeds** | [**StudentDemographicsSenNeeds**](StudentDemographicsSenNeeds.md) |  | [optional] 
**CountryOfBirth** | **string** | The country of birth of the student | [optional] 
**Nationalities** | **List&lt;string&gt;** | The nationality or nationalities of the student | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

