using System;

namespace WorkingWithMultidimensionalArrays
{
    class MultidimensionalArrays
    {
        public static void Main(string[] args)
        {
            // defining multidimensional array
            int[,] numbers = new int[3, 4] {
                                { 2, 3, 4, 5 },
                                { 10, 15, 50, 6 },
                                { 65, 10, 453, 19 }
                            };

            // Loop through the array using proper bounds
            // Array.GetLength(0) => provides row length
            // Array.GetLength(1) => provides column length
            for (int i = 0; i < numbers.GetLength(0); i++) // Row count
            {
                for (int j = 0; j < numbers.GetLength(1); j++) // Column count
                {
                    Console.Write($"{numbers[i, j]}");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
