
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