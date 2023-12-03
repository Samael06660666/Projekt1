Console.WriteLine("Napisz Imię:");
var name = Console.ReadLine();

Console.WriteLine("Napisz płeć");
var sex = Console.ReadLine();

Console.WriteLine("Napisz wiek");
var ageasString = Console.ReadLine();
var age = int.Parse(ageasString);

if (age >= 18)
{
    Console.WriteLine("Powyżej 18 roku życia");
}
 if (age == 33)
{
    Console.WriteLine("Osoba miejąca 33 lata");
}
if (age < 18)
{
    Console.WriteLine("Osoba niepełnoletnia");
}