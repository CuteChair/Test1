// See https://aka.ms/new-console-template for more information



Console.Write("Bonjour, quelle est votre nom : ");
string n = Console.ReadLine();

//string interpolation
Console.WriteLine($"Bienvenue {n} dans l<application!");
Console.Write("entrer une temperature : ");

double celc = Convert.ToDouble(Console.ReadLine());
double far = celc * 9 / 5 + 32;

Console.WriteLine($"Il fait {far} degres fahrenheit: ");
Console.ReadKey();