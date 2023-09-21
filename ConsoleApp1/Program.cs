// See https://aka.ms/new-console-template for more information



Console.Write("Hi, whats your name: ");
string n = Console.ReadLine();

//string interpolation
Console.WriteLine($"Welcome {n} in the app!");
Console.Write("enter a temperature : ");

double celc = Convert.ToDouble(Console.ReadLine());
double far = celc * 9 / 5 + 32;

Console.WriteLine($"Its {far} degres fahrenheit outside: ");
Console.ReadKey();