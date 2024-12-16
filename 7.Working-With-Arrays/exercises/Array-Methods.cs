/*
    Array Methods In C#
    ===================
    Array.Sort()
    Array.Reverse()
    Array.Replace()
    Array.Concat()
    Array.Remove()
    Array.Copy()
    Array.Fill()

*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the array length: ");
        int arrLength = Convert.ToInt32(Console.ReadLine());

        // Declared array
        int[] numbers = new int[arrLength];

        Console.WriteLine("Please enter the array elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Please enter your choice operation: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        string promptMessage = string.Empty; // Initially empty string

        switch (choice)
        {
            case 0: // Sorting
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

            case 1: // Reverse
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

            case 2: // Copy
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
            case 3:
                Array.Clear(numbers);
                System.WriteLine("Cleared array: {0}", numbers.Length);

            case 4:
                // IndexOf() returns -1 if existes, otherwise the index value
                var value = Array.IndexOf(numbers, 2); // find the value 44 in numbers array
                System.WriteLine("Index : {0}", value);
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
