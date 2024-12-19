/*
    List Methods In C#
    ==================
    1. List.Count                   => returns the length of the list
    2. List.Add(item)               => add specified item in the list
    3. List.Insert(index, item)     => insert item in the specified index
    4. List.Remove(item)            => remove the specified item first occurence from the list
    5. List.RemoveAt(index)         => remove the item at the specified position in the list
    6. List.Find(predicate)         => find the item depending on the specified predicate
    7. List.Reverse()               => reverse the list
    8. List.Contains(item)          => check if the item exists returns True or False
    9. List.Sort()                  => sort the list
    10. List.IndexOf(item)          => returns the index of the specified item\
    11. List.ToArray()              => convert list item to an array

 

*/

using System;
using System.Collections.Generic;
using Internal;

class PerformOperationOnList
{
    private List<string> list;

    public PerformOperationOnList()
    {
        list = new List<string> { "Warfaze", "Artcell", "Black", "Aurthohin" };
    }

    public void PerformOperation(int choice)
    {
        switch (choice)
        {
            case 1:
                // Create List
                Console.WriteLine("List Created:");
                Console.WriteLine(string.Join(", ", list));
                break;

            case 2:
                // Read List
                Console.WriteLine("Choose reading method:");
                Console.WriteLine("1. Traditional for loop");
                Console.WriteLine("2. foreach loop");
                Console.Write("Your choice: ");
                int readChoice = Convert.ToInt32(Console.ReadLine());

                if (readChoice == 1)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {list[i]}");
                    }
                }
                else if (readChoice == 2)
                {
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice for reading method.");
                }
                break;

            case 3:
                // Add Item to List
                Console.Write("Enter the item to add: ");
                string newItem = Console.ReadLine();
                list.Add(newItem);
                Console.WriteLine($"Item '{newItem}' added.");
                break;

            case 4:
                // Find Item in List
                Console.Write("Enter the item to find: ");
                string itemToFind = Console.ReadLine();
                var foundItem = list.Find(x => x.Equals(itemToFind, StringComparison.OrdinalIgnoreCase));
                if (foundItem != null)
                {
                    Console.WriteLine($"Item '{itemToFind}' found.");
                }
                else
                {
                    Console.WriteLine($"Item '{itemToFind}' not found.");
                }
                break;

            case 5:
                // Clear List
                list.Clear();
                Console.WriteLine("List cleared.");
                break;

            case 6:
                // Remove Item from List
                Console.Write("Enter the item to remove: ");
                string itemToRemove = Console.ReadLine();
                if (list.Remove(itemToRemove))
                {
                    Console.WriteLine($"Item '{itemToRemove}' removed.");
                }
                else
                {
                    Console.WriteLine($"Item '{itemToRemove}' not found.");
                }
                break;
            case 7:
                // reverse the list
                list.Reverse();
                Console.WriteLine("Reversed list: {0}", list);
                break;
            case 8:
                // check if a value contains
                const bool isContain = list.Contains("Warfaze");
                Console.WriteLine("Contains \'Warfaze\' : {0}", isContain);

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public static void Main(string[] args)
    {
        PerformOperationOnList operation = new PerformOperationOnList();

        Console.WriteLine("Welcome to play with C# List");
        Console.WriteLine("Available operations:");
        Console.WriteLine("1. Create List");
        Console.WriteLine("2. Read List");
        Console.WriteLine("3. Add Item to List");
        Console.WriteLine("4. Find Item in List");
        Console.WriteLine("5. Clear List");
        Console.WriteLine("6. Remove Item from List");
        Console.WriteLine("7. Reverse The List");
        Console.WriteLine("8. Check an Item contains in List");


        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        operation.PerformOperation(choice);
    }
}
