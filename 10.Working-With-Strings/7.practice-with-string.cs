// declaration 
using Internal;
using System;

using System;

namespace StringManipulationOperation
{
    class Program
    {
        // Predefined string
        static string BangladeshiBands = "Arbovirus, Warfaze, Aurthohin, Crptic Fate, Black";

        // Main method to run the program
        public static void Main(string[] args)
        {
            string promptMessage = @"
                WELCOME TO THE GAME OF STRING OPERATION ON C#,   
                    Select the choice: 
                    1. Make Upper Or LowerCase
                    2. Replace A String
                    3. Get A Portion of string
                    4. Get The Array Of String
                    5. Get the index value of string
                    6. Get the hash code of the string
                    7. Get the length of the string
                    8. Check if null or empty
                    9. Format the string 
                    10. Convert/Cast Other Variable To String
                    11. Compare Strings
                    12. Perform a search on the string
                    Exit: enter -1
                ";

            while (true)
            {
                Console.WriteLine(promptMessage);
                string choice = Console.ReadLine();

                if (choice == "-1")
                {
                    break; // Exit the program
                }

                switch (choice)
                {
                    case "1": // Make Upper or Lower Case
                        Console.WriteLine("a. Upper  b. Lower");
                        string caseChoice = Console.ReadLine();

                        if (caseChoice == "a")
                        {
                            string upperCaseResult = operationOnString(BangladeshiBands, 1);
                            Console.WriteLine($"Result: {upperCaseResult}");
                        }
                        else if (caseChoice == "b")
                        {
                            string lowerCaseResult = operationOnString(BangladeshiBands, 2);
                            Console.WriteLine($"Result: {lowerCaseResult}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice.");
                        }
                        break;

                    case "2": // Replace A String
                        Console.WriteLine("Enter the string to replace:");
                        string oldValue = Console.ReadLine();
                        Console.WriteLine("Enter the new string:");
                        string newValue = Console.ReadLine();
                        string replaceResult = BangladeshiBands.Replace(oldValue, newValue);
                        Console.WriteLine($"Result: {replaceResult}");
                        break;

                    case "3": // Get A Portion of string
                        Console.WriteLine("Enter start index:");
                        int startIndex = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter length:");
                        int length = Convert.ToInt32(Console.ReadLine());
                        string substringResult = BangladeshiBands.Substring(startIndex, length);
                        Console.WriteLine($"Result: {substringResult}");
                        break;

                    case "4": // Get The Array Of String (split by comma)
                        string[] arrayResult = BangladeshiBands.Split(',');
                        Console.WriteLine("Array of Bands:");
                        foreach (string band in arrayResult)
                        {
                            Console.WriteLine(band.Trim());
                        }
                        break;

                    case "5": // Get the index value of string
                        Console.WriteLine("Enter the string to search for:");
                        string searchString = Console.ReadLine();
                        int indexResult = BangladeshiBands.IndexOf(searchString);
                        Console.WriteLine($"Index: {indexResult}");
                        break;

                    case "6": // Get the hash code of the string
                        int hashCodeResult = BangladeshiBands.GetHashCode();
                        Console.WriteLine($"Hash Code: {hashCodeResult}");
                        break;

                    case "7": // Get the length of the string
                        int lengthResult = BangladeshiBands.Length;
                        Console.WriteLine($"Length: {lengthResult}");
                        break;

                    case "8": // Check if null or empty
                        bool isNullOrEmpty = string.IsNullOrEmpty(BangladeshiBands);
                        Console.WriteLine($"Is null or empty: {isNullOrEmpty}");
                        break;

                    case "9": // Format the string
                        Console.WriteLine("Enter a format string:");
                        string format = Console.ReadLine();
                        string formattedResult = string.Format(format, BangladeshiBands);
                        Console.WriteLine($"Formatted Result: {formattedResult}");
                        break;

                    case "10": // Convert/Cast Other Variable To String
                        Console.WriteLine("Enter a number to convert to string:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        string numberAsString = number.ToString();
                        Console.WriteLine($"Converted String: {numberAsString}");
                        break;

                    case "11": // Compare Strings
                        Console.WriteLine("Enter string to compare with:");
                        string compareTo = Console.ReadLine();
                        int comparisonResult = string.Compare(BangladeshiBands, compareTo);
                        Console.WriteLine($"Comparison Result: {comparisonResult}");
                        break;

                    case "12": // Perform a search on the string
                        Console.WriteLine("Enter the string to search for:");
                        string searchStr = Console.ReadLine();
                        bool containsResult = BangladeshiBands.Contains(searchStr);
                        Console.WriteLine($"Contains the string? {containsResult}");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        // Method to handle string case transformations (UpperCase / LowerCase)
        public static string operationOnString(string input, int choice)
        {
            if (choice == 1)
            {
                return input.ToUpper(); // Convert to UpperCase
            }
            else if (choice == 2)
            {
                return input.ToLower(); // Convert to LowerCase
            }
            else
            {
                return input; // Default: return input as is
            }
        }
    }
}
