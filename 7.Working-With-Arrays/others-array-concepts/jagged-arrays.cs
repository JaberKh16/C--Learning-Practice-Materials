using System;


namespace WorkingWithJaggedArray
{
    class JaggedArrays
    {
        public static void Main(string[] args)
        {
            // defining jagged array
            int[][] numbers =   {
                        new int[] { 2, 3, 4, 5 },
                        new int[] { 14, 15, 50, 6, 34, 10, 12 } ,
                        new int [] { 65, 10, 453, 19 }
                    };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write(numbers[i][j]);
                }
                Console.WriteLine("\n");
            }
        }

    }
}
