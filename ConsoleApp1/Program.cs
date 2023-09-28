// See https://aka.ms/new-console-template for more information


/*
Console.Write("Hi, whats your name: ");
string n = Console.ReadLine();

//string interpolation
Console.WriteLine($"Welcome {n} in the app!");
Console.Write("enter a temperature : ");

double celc = Convert.ToDouble(Console.ReadLine());
double far = celc * 9 / 5 + 32;

Console.WriteLine($"Its {far} degres fahrenheit outside: ");
*/

double key = 0;
Console.WriteLine("Bienvenu dans l'app, quel est votre nom : ")
    string name = Console.ReadLine();
Console.WriteLine($"Bonjour {name} !");
Console.WriteLine("Voulez-vous la temperature en fahrenhait ou en celcius? \n Pour les degres fahrenhait appuyer sur 1 \n Et pour les degres celcius appuyez sur 2 : ");
key = Convert.ToDouble(Console.ReadLine());
if (key == 1 )

Console.ReadKey();