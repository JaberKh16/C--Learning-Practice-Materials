// See https://aka.ms/new-console-template for more information

using System;


// alternate ways of creating array
/*
    datatype [] arrName = new datatype [N];
    datatype [] arrName = new datatype [] {1 ... n};
    datatype [] arrName = new();
*/

// making arrays - fixed length
var HWIMYMSeries = new String[] { "Ted", "Lili", "Marshal", "Barney", "Robin" };

// another way of declaring array
List <int> list = ["Ted", "Lili", "Marshal", "Barney", "Robin" ]; 


// another way of declaring array
var numbers = {11, 43, 64, 323, 34, 32, 6, 72};
int [] ints= {10, 20, 30, 40, 50};


Console.WriteLine($"{HWIMYMSeries}");
Console.WriteLine($"{HWIMYMSeries.Count}");

// using traditional for loop
for(int i = 0; i < HWIMYMSeries.Count; i++) {
    Console.WriteLine("" + HWIMYMSeries[i]);
}


// // add items into the list
// HWIMYMSeriesArray = [..HWIMYMSeries, "Trudy"];

// // using foreach loop
// foreach (var characters in HWIMYMSeries)
// {
//     Console.WriteLine("" + characters.ToUpper());
// }

// // accessing single item
// Console.WriteLine($"The third character is: {HWIMYMSeries[2]}"); // forward moving 
// Console.WriteLine($"The third character is: {HWIMYMSeries[HWIMYMSeries.Count - 1]}");
// Console.WriteLine($"The third character is: {HWIMYMSeries[^2]}"); // background moving



// // using foreach loop with ranging
// foreach (var characters in HWIMYMSeries[2...4])
// {
//     Console.WriteLine("" + characters.ToUpper());
// }