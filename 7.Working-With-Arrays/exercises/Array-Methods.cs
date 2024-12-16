/*
    Array Methods In C#
    ===================
    Array.Sort(arr)                 => Sort the array ascending order in place
    Array.Reverse(arr)              => Reverse the array in place
    Array.Replace(arr, value)       => Replace a specified item in the array in place
    Array.Concat()                  => Concat items in an array 
    Array.Remove(arr, value)        => Remove item from the array
    Array.Copy()                    => Copy item from the array
    Array.Fill()                    => Fill the array with specified value
    Array.Clear()                   => Clear the array
    Array.IndexOf()                 => Get the index of the specified item
    

*/

using System;
using Internal;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to play with C# List");
        Console.WriteLine("Available operations:");
        Console.WriteLine("1. Create An Array");
        Console.WriteLine("2. Read Array");
        Console.WriteLine("3. Sort Array");
        Console.WriteLine("4. Reverse Array");
        Console.WriteLine("5. Copy Array");
        Console.WriteLine("6. Clear Array");
        Console.WriteLine("7. Get the index value of a item");
        Console.WriteLine("8. Fill array with some value");
        Console.WriteLine("9. Check if a value exists in the array");
        Console.WriteLine("10. Find a value in the array");
        Console.WriteLine("11. Find all values matches condition in the array");
        Console.WriteLine("12. Perforom a binary search on the array");
        Console.WriteLine("13. Clone the array");
        Console.WriteLine("14. Get Array Dimension");
        Console.WriteLine("15. Resize the array");
        Console.WriteLine("Please enter the array length: ");
        int arrLength = Convert.ToInt32(Console.ReadLine());

        // Declared array
        int[] numbers = new int[arrLength];

        Console.WriteLine("Please enter your choice operation: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        string promptMessage = string.Empty; // Initially empty string

        switch (choice)
        {
            case 0: // create

                Console.WriteLine("Please enter the array elements:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                break;
            case 1:
                Console.WriteLine("Array Items are: ");
                PrintArray(numbers);


            case 2: // Sorting
                promptMessage = @"Enter your choice:
                                1. Simple Sorting
                                2. Sorting a portion of the array";
                Console.WriteLine(promptMessage);
                string subchoiceSort = Console.ReadLine();

                if (!string.IsNullOrEmpty(subchoiceSort))
                {
                    if (subchoiceSort == "1")
                    {
                        Array.Sort(numbers); // Inline sort
                        Console.WriteLine("Sorted array:");
                        PrintArray(numbers);
                    }
                    else if (subchoiceSort == "2")
                    {
                        if (numbers.Length >= 6)
                        {
                            Array.Sort(numbers, 1, 5); // Sorting portion of the array
                            Console.WriteLine("Partially sorted array:");
                            PrintArray(numbers);
                        }
                        else
                        {
                            Console.WriteLine("Array must have at least 6 elements for partial sorting.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option for sorting.");
                    }
                }
                else
                {
                    Console.WriteLine("Please choose an option.");
                }
                break;

            case 3: // Reverse
                promptMessage = @"Enter your choice:
                                1. Reverse";
                Console.WriteLine(promptMessage);
                string subchoiceReverse = Console.ReadLine();

                if (!string.IsNullOrEmpty(subchoiceReverse))
                {
                    if (subchoiceReverse == "1")
                    {
                        Array.Reverse(numbers);
                        Console.WriteLine("Reversed array:");
                        PrintArray(numbers);
                    }
                    else
                    {
                        Console.WriteLine("Invalid option for reversing.");
                    }
                }
                else
                {
                    Console.WriteLine("Please choose an option.");
                }
                break;

            case 4: // Copy
                promptMessage = @"Enter your choice:
                                1. Copy to a new array
                                2. Copy with specific indices";
                Console.WriteLine(promptMessage);
                string subchoiceCopy = Console.ReadLine();

                if (!string.IsNullOrEmpty(subchoiceCopy))
                {
                    if (subchoiceCopy == "1")
                    {
                        int[] copyArr = new int[numbers.Length];
                        Array.Copy(numbers, copyArr, numbers.Length);
                        Console.WriteLine("Copied array:");
                        PrintArray(copyArr);
                    }
                    else if (subchoiceCopy == "2")
                    {
                        Console.WriteLine("Enter the number of elements to copy:");
                        int lengthToCopy = Convert.ToInt32(Console.ReadLine());

                        if (lengthToCopy > 0 && lengthToCopy <= numbers.Length)
                        {
                            int[] copyArr = new int[lengthToCopy];
                            Array.Copy(numbers, 0, copyArr, 0, lengthToCopy);
                            Console.WriteLine("Copied portion of array:");
                            PrintArray(copyArr);
                        }
                        else
                        {
                            Console.WriteLine("Invalid length for copying.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option for copying.");
                    }
                }
                else
                {
                    Console.WriteLine("Please choose an option.");
                }
                break;
            case 5: // Reverse
                Array.Reverse(numbers);
                Console.WriteLine("Reversed array: {0}", numbers.Length);
            case 6: // Clear
                Array.Clear(numbers);
                Console.WriteLine("Cleared array: {0}", numbers.Length);

            case 7: // Find Index
                // IndexOf() returns -1 if existes, otherwise the index value
                var value = Array.IndexOf(numbers, 2); // find the value 44 in numbers array
                Console.WriteLine("Index : {0}", value);

            case 8: // Fill Array
                // fill the arrays
                int[] numbers = new int[5];
                Console.WriteLine("Please enter a number to fill with: ");
                const int value = Convert.ToInt32(System.ReadLine());
                Array.Fill(numbers, value); // { value, value, value, value, value }
                Console.WriteLine($"Filled Array: {numbers}");
            case 9: // Check Existence Of An Item
                // check if a item exists
                Console.WriteLine("Please enter a number to check if exists: ");
                const int value = Convert.ToInt32(System.ReadLine());
                bool exists = Array.Exists(numbers, x => x == value);
                Console.WriteLine($"Exists: {exists}");
            case 10: // Find An Item Matches Condition
                // find an item in the array
                Console.WriteLine("Please enter a number to check if exists: ");
                const int value = Convert.ToInt32(System.ReadLine());
                int found = Array.Find(numbers, x => x > value);
                Console.WriteLine($"Item Found: {found}");
            case 11: // Find All Item Matches Condition
                // find all item in the array
                Console.WriteLine("Please enter a number to check if exists: ");
                const int value = Convert.ToInt32(System.ReadLine());
                int[] results = Array.FindAll(numbers, x => x > value);
                Console.WriteLine($"Returned Array: {results}");
            case 12: // Binary Search
                // binary search in the array
                Console.WriteLine("Please enter a number to check if exists: ");
                const int value = Convert.ToInt32(System.ReadLine());
                int index = Array.BinarySearch(numbers, value);
                Console.WriteLine($"Item Found At: {index}");
            case 13: // Clone Array
                // Clone an array
                Console.WriteLine("Please enter a number to check if exists: ");
                const int value = Convert.ToInt32(System.ReadLine());
                int[] cloneArray = (int[])Array.Clone(numbers);
                Console.WriteLine($"Cloned Array: {cloneArray}");
            case 14: // Get Array Dimension
                // Array Dimension
                const int value = Convert.ToInt32(System.ReadLine());
                int rank = matrix.Rank;
                Console.WriteLine($"Array Dimension: {rank}");
            case 15: // Resize the array
                Array.Resize(ref numbers, 10); // {v1 v2, v3, v4, v5, 0, 0, 0, 0, 0}
                Console.WriteLine($"Resized Array:  {numbers}");
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }


        // call the function to print the array
        PrintArray(numbers);
    }

    // Helper method to print array
    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }


}
