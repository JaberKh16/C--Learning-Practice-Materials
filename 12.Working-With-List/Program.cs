

var namesList = new List<string> { "Warfaze", "Artcell", "Black", "Aurthohin"}; 

foreach (var item in namesList)
{
    Console.WriteLine(item);
}

// adding item
namesList.Add("Arbovirus");


foreach (var item in namesList)
{
    Console.WriteLine(item);
}

