/*
    Access Modifiers In C#
    ======================
    C# provides diferent access modifiers to work with. Those access modifiers are the following:
        
        1. public               => accessible all over the classes itself and the namespace it is defined
        2. private              => accessible within the class itself only
        3. protected            => accessible within class or inherited child class or base class
        4. intrnal              => accessible within its own assembly, but not from another assembly
        5. protected internal   => accessible within assembly, not in other assembly
        6. private protected    => accessible within class and derived class only, but not in another assembly any class
*/

class Person
{
    public String name;
    public String age;

    public string PersonName { get; set; }

    public Person(String name, String age)
    {
        this.name = name;
        this.age = age;
    }

    public static void Main(string[] args)
    {
        Person person = new Person("John Carter", 29);
        person.PersonName();


    }
}