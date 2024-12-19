/*
    String Methods Are The Follows
    ==============================
    1. string.Length                            --> returns the string length
    2. string.IsNullOrEmpty(str)                --> checks whether the specified string is null or empty string and returns a boolean
    3. string.Replace(oldstr, newstr)           --> returns a new string withe replace string or char
    4. string.Substring(startindex, endindex)   --> returns substring of string on the specified start and end index
    5. string.Split(char)                       --> returns a list split on some characters


    Note: Refer this page for string methdos - https://medium.com/@praveen.rao.g.1990/working-with-strings-in-c-a-comprehensive-guide-242ca55934b0

*/

using System;


string s1 = "Something is fissy.";
string s2 = "Needs to be fixed";


// find length
Console.WriteLine($"Length of s1: {s1.Length}");

if(string.IsNullOrEmpty(s1)){
    Console.WriteLine($"s1 is not null or empty");
} else{
    Console.WriteLine($"s1: {s1.Length}");
}

// find the substring
Console.WriteLine($"Substring From 2 to 5: {s1.Substring(2, 5)}");
Console.WriteLine($"Substring From 0 to 5: {s1.Substring(5)}");


// splits string
const string osItems = "Apple, Android, iOS, Windows, Blackberry, Linux";
string [] splittedValues = osItems.Split(','); // returns an array 
Console.WriteLine($"{splittedValues}"); // prints the string object

for(int i = 0; i < splittedValues.Length; i++)
{
    Console.WriteLine($"{splittedValues[i]}");
}

// replace string
string text = "C# is awesome!";
string newText = text.Replace("awesome", "amazing"); // "C# is amazing!"


// comparing
string s11 = "élite";
string s22 = "elite";

int result = string.Compare(s11, s22, StringComparison.CurrentCulture); // 1 (s1 is greater)


string str1 = "Hello";
string str2 = "hello";
bool areEqual = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase); // true


// convert to string
string salary = 34535.043.ToString();
Console.WriteLine($"{salary}");
Console.WriteLine($"{salary:C}");


// formatting string - ToString()
decimal amount = 23243.3224m;
string formattedValue = amount.ToString("C"); // C stands Currency format in C#
Console.WriteLine($"{formattedValue}");



// Format()
int apples = 5;
int bananas = 3;
string message = string.Format("I have {0} apples and {1} bananas.", apples, bananas);
Console.WriteLine($"{message}");





