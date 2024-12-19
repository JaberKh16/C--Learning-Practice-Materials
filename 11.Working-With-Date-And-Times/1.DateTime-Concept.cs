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