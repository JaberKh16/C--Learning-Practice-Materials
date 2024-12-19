
// Use of TimeOnly() 
var timeNow = DateOnly.FromDateTime(new DateTime.Now);
Console.WriteLine($"Time is: {timeNow}");
Console.WriteLine($"Time is: {timeNow:hh:mm tt}"); // wih the time format