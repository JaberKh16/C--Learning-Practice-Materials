using System;

class WorkingWithStruct
{
    // Define a struct
    struct PersonInfo
    {
        public string Name;
        public int Age;
        public DateOnly Birthday;
        public string Country;
        public string Phone;

        // Method to initialize struct fields
        public void InitializeValues(string name, int age, DateOnly birthday, string country, string phone)
        {
            this.Name = name;
            this.Age = age;
            this.Birthday = birthday;
            this.Country = country;
            this.Phone = phone;
        }

        // Method to display person's information
        public void GetPersonInformation()
        {
            Console.WriteLine("Person Information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Birthday: {Birthday}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Phone: {Phone}");
        }
    }

    public static void Main(string[] args)
    {
        // Create an instance of the struct
        PersonInfo person = new PersonInfo();

        // Initialize with values
        person.InitializeValues("Mr. X", 25, new DateOnly(1994, 5, 14), "Korea", "+97242488792");

        // Display the person's information
        person.GetPersonInformation();
    }
}
