using System;

class EnumProgram
{
    // Define an enum
    enum CardsGame
    {
        // index range  0 - 5
        TwentyNine, // Renamed from "29 Cards"
        Spades,
        CallBridge,
        TeenPatti,  // Renamed from "Teen Patti"
        SevenCards  // Renamed from "7 Cards"
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enum Datatype examples are:");

        // Iterate over the enum values using Enum.GetValues()
        foreach (var card in Enum.GetValues(typeof(CardsGame)))
        {
            Console.WriteLine(card);
        }
    }
}
