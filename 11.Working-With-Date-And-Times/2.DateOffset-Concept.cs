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