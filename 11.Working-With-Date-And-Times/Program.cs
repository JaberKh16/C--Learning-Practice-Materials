// See https://aka.ms/new-console-template for more information
/*
    C# Available Date Types
    ------------------------
    a. DateTime           -- includes general formaty date and time
    b. DatOnly            -- includes date only without timezone
    c. DateTimeOffset     -- includes time zone offset information
    d. TimeOnly           -- includes only the time


*/

using System;
using System.Globalization;

// empty datetime object
DateTime dateTime = new DateTime();
Console.WriteLine($"{dateTime}");

// create a DateTime from date and time
var dateOfBirth = new DateTime(1970, 10, 11);
Console.WriteLine($"{dateOfBirth}");

// DateTime with year, month, day, hour, minute, second
var exactDateOfBirth = new DateTime(1994, 04, 14, 14, 45, 23);
Console.WriteLine($"{exactDateOfBirth}");

// access properties
Console.WriteLine($"Day of week: {exactDateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of year: {exactDateOfBirth.DayOfYear}");
Console.WriteLine($"Time of day: {exactDateOfBirth.TimeOfDay}");
Console.WriteLine($"Ticks: {exactDateOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactDateOfBirth.Kind}");


// DateTime with year, month, day, hour, minute, second
var exactDateOfBirthWithKind = new DateTime(1994, 04, 14, 14, 45, 23, DateTimeKind.Local);
Console.WriteLine($"{exactDateOfBirthWithKind}");

// access properties
Console.WriteLine($"Day of week: {exactDateOfBirthWithKind.DayOfWeek}");
Console.WriteLine($"Day of year: {exactDateOfBirthWithKind.DayOfYear}");
Console.WriteLine($"Time of day: {exactDateOfBirthWithKind.TimeOfDay}");
Console.WriteLine($"Ticks: {exactDateOfBirthWithKind.Ticks}");
Console.WriteLine($"Kind: {exactDateOfBirthWithKind.Kind}");



// parse datetime
Console.WriteLine("Tell me a date time(dd/mm/yyyy)");
string dob = Console.ReadLine();
var userProvidedDob = DateTime.Parse(dob);
Console.WriteLine($"User provided dob is: {userProvidedDob}");


// change format datetime
// DateTime.ToString("format") to format the datetime into specified format
Console.WriteLine($"User provided dob is: {userProvidedDob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"User provided dob is: {userProvidedDob.ToString("dd-MM-yyyy")}");
Console.WriteLine($"User provided dob is: {userProvidedDob.ToString("MM, dd-yyyy")}");
Console.WriteLine($"User provided dob is: {userProvidedDob.ToString("dd-MMM-yyyy")}");
Console.WriteLine($"User provided dob is: {userProvidedDob.ToString("dddd, dd, MMMM, yyyy")}");


// current datetime
var currentDateTime = DateTime.Now;
Console.WriteLine($"{currentDateTime}");


// methods of datetime object
Console.WriteLine($"One hour from now is: {currentDateTime.AddHours(1)}");
Console.WriteLine($"One day from now is: {currentDateTime.AddDays(1)}");
Console.WriteLine($"45 mins from now is: {currentDateTime.AddMinutes(45)}");


// DateTimeOffset() - utcNow
var utcNow = DateTime.UtcNow;
Console.WriteLine($"Now datetime : {currentDateTime}");
Console.WriteLine($"UTC Now datetime : {utcNow}");


// create DateTimeOffset and Timezone info --> offset provides the difference
var tz = TimeZoneInfo.Local.GetUtcOffset(currentDateTime);
Console.WriteLine($"User Timezone: {tz}");



// create datetime offset with -7 timezone
var dateWithManualTimeSpan = new DateTimeOffset(currentDateTime, new TimeSpan(-7, 0, 0));
Console.WriteLine($"DateTime with hard coded offset : {dateWithManualTimeSpan}");

// datetime with timezone
var dto = new DateTimeOffset(currentDateTime, tz);
Console.WriteLine($"User timezone with UTC offset: {dto}");
Console.WriteLine($"UTC time of action: {dto.UtcDateTime}");


// setup timezone to specific zone
var indiaTz = TimeZoneInfo.FindSystemTimezoneById("India Standard Time");
var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
Console.WriteLine($"Action was completed in India at: {indiaDateTime}");


// Use of DateOnly()
var dateOnly = new DateOnly(1980, 12, 10);
var nextDay = dateOnly.AddDays(1);
var previousDay = dateOnly.AddDays(-1);
var nextDecade = dateOnly.AddYears(10);
var lastMonth = dateOnly.AddMonth(-1);

Console.WriteLine($"The date: {dateOnly}");
Console.WriteLine($"The next day: {nextDay}");
Console.WriteLine($"The previous day: {previusDay}");
Console.WriteLine($"The decade later: {nextDecade}");
Console.WriteLine($"The last month: {lastMonth}");


// DateOnly.FromDateTime()
var dateOnlyFromDateTime = DateOnly.FromDateTime(new DateTime.Now);
Console.WriteLine($"Date only from datetime: {dateOnlyFromDateTime}");


Console.WriteLine("Enter a date: (dd/mm/yyyy)");
var enteredDate = Console.ReadLine();
var dateOnlyFromUser = DateOnly.ParseExact(enteredDate, "dd MMM yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"Entered Date is : {dateOnlyFromUser}");



// Use of TimeOnly() 
var timeNow = DateOnly.FromDateTime(new DateTime.Now);
Console.WriteLine($"Time is: {timeNow}");
Console.WriteLine($"Time is: {timeNow:hh:mm tt}"); // wih the time format


// Comparing Two DateTime
var date1 = new DateTime(1998, 1, 10);
var date2 = new DateTime(1998, 1, 10);



// can compare using >, < , ==, Equals(), 
if (date1.Equals(date2))
{
    Console.WriteLine($"Both are equal");
}
else
{
    Console.WriteLine($"Both are not equal");
}