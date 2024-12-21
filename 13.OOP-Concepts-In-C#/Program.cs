using System;


class Employee
{   
    // properties 
    // Format => PascalCase
    public int Id { get; set;}
    public string Name { get; set;}
    public string Designation { get; set;}
    public string Departments { get; set;}
    public float Salary { get; set;}

    // fields
    // Format => camelCase
    private double _salary;

    // methods
    // Format => PascalCase
    public string GetEmployeeName(){
        return $"{Name}";
    }

    public double GetSalary(){
        return _salary;
    }

    // // constructor
    // public Employee(int id, string name, string designation, string departments, float salary)
    // {
    //     Id = id;
    //     Name = name;
    //     Designation = designation;
    //     Departments = departments;
    //     Salary = salary;
    // }

    public static void Main(string [] args){
        
        // create the instance
        Employee emp = new Employee();
        Console.WriteLine($"Object is : {emp} and Type: {emp.GetType()}");

        emp._salary = 30000;
        float salary = Convert.ToInt32(emp.GetSalary()); 
        Console.WriteLine($"{salary}");

        // set values

        string name = emp.GetEmployeeName();
        Console.WriteLine($"{name}");
    }
}

