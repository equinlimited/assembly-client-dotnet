# Assembly Developer API .NET Client

This library targets **.NET Standard 2.0** and can be used in *.Net Core 2.2* or *.NET 4.5* and above projects.

## Installation

If using Visual Studio NuGet, ensure **prerelease** is checked in your NuGet Client.

Install the NuGet package into your Project:

```powershell
Install-Package assembly-client-dotnet
```

## Usage

Some examples of how to pull information from the Assembly Platform API using the client.

```c#
var config = new ApiConfiguration()
{
  Token = "my_oauth_access_token",
  RefreshToken = "my_oauth_refresh_token",
  ClientId = "my_client_id",
  ClientSecret = "my_client_secret"
};

// To connect to the live Platform, rather than the Sandbox environment, use simply: new ApiClient();
var client = new ApiClient(AssemblyEnvironment.Sandbox);
client.Configure(config);

// -----------------------------------------------------------------

// Registration Groups

// Fetch registration groups, filtered by a year group.
var regGroups = await client.RegistrationGroups.List(yearCode: "7");

foreach (var group in regGroups)
{
  Console.WriteLine($"Group Name: {group.Name}");
}

// -----------------------------------------------------------------

// Teaching Groups

// Fetch all teaching groups (you may know these as classes) for the mathematics subject code.
var mathsGroups = await client.TeachingGroups.List(subjectCode: "MA");

foreach (var group in mathsGroups)
{
  Console.WriteLine($"Group Name: {group.Name}");
}

// You can also apply a date filter to get, say, teaching groups from last academic year or for another specific range of time.
var mathsGroupsFiltered = await client.TeachingGroups.List(startDate: DateTime.Parse("2016-09-01"), endDate: DateTime.Parse("2017-07-31"));

// Fetch all the students for this teaching group.
var mathsStudents = await mathsGroups.First().Students();

foreach (var student in mathsStudents)
{
  Console.WriteLine($"{student.LastName}, {student.FirstName} ({student.YearCode})");
}

// -----------------------------------------------------------------

// Students

// Fetch all students filtered by year code/year group
var year7Students = await client.Students.List(yearCode: "7", demographics: true);

foreach (var student in year7Students)
{
  Console.WriteLine($"{student.LastName}, {student.FirstName} ({student.YearCode})");
}

// -----------------------------------------------------------------

// Year Groups

// Fetch all the year groups.
var yearGroups = await client.YearGroups.List();

foreach (var yearGroup in yearGroups)
{
  Console.WriteLine($"{yearGroup.Code} {yearGroup.Name}");
}

// Fetch the students for this particular year group.
var yearGroupStudents = await yearGroups.First().Students();

// -----------------------------------------------------------------

// Academic Years

// Fetch all the academic years
var academicYears = await client.AcademicYears.List();

// View the terms for this academic year
var firstYearTerms = academicYears.First().Terms;

// -----------------------------------------------------------------

// Staff Members

var staffMembers = await client.StaffMembers.All();

foreach (var staffMember in staffMembers)
{
  Console.WriteLine($"{staffMember.LastName}, {staffMember.FirstName} ({staffMember.IsTeachingStaff})");
}

// -----------------------------------------------------------------

// Subjects

// Fetch all the subjects
var subjects = await client.Subjects.List();

// -----------------------------------------------------------------

// Aspects

// Fetch all the aspects
var aspects = await client.Aspects.List();

// -----------------------------------------------------------------

// Assessment Points

// Fetch all the assessment points
var assessmentPoints = await client.AssessmentPoints.List();

// -----------------------------------------------------------------

// Assessments

// Fetch all the assessments
var assessments = await client.Assessments.List();

// -----------------------------------------------------------------

// Grade Sets

// Fetch all the grade sets
var gradeSets = await client.GradeSets.List();

// -----------------------------------------------------------------

// Results

// Write a set of results in one batch (maximum of 50 results at one time)
var resultsBatch = new ResultsBatch
{
  AspectId = 1,
  AssessmentId = 1,
  AssessmentPointRank = 1,
  SubjectId = 1
};

resultsBatch.AddResult(studentId: 1, gradeId: 1);
resultsBatch.AddResult(studentId: 2, gradeId: 1);

var response = await client.Results.WriteResults(resultsBatch);

// Fetch all the results for a given list of students
var studentIds = new List<int> {1, 2, 3};
var results = await client.Results.List(studentIds);

// -----------------------------------------------------------------

// School Details

// Fetch the school details
var schoolDetails = await client.School.Details();

```
