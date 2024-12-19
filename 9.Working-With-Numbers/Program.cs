double num1 = 10.32D;
double num2 = 20.4345D;
double c =  num1 / num2;

Console.WriteLine("C value is: {0}", c); // positional value
Console.WriteLine($"C value is: {c}"); // interpolatrion value
Console.WriteLine(string.Format("{0:0.00}", c)); // formating precision 0.00
Console.WriteLine(string.Format("{0:0.0}", c)); // formating precision 0.0



