string Name = "Alex";
int Age = 24;
var sex = "male";
string Name2 = "Ewa";
int age2 = 33;
var sex2 = "famale";
string name3 = "Zofia";
int age3 = 15;
var sex3 = "Famale";

bool isActive = true;

if (Age > 18)
{ if (sex == "male")
    
        Console.WriteLine("Aleksander Mężcyzna Pełnoletni ");
    
    }
    else if (Age > 18)
    {
            Console.WriteLine("Niepełnoletni");
}
bool isActice2 = true;
if (age2 > 18)
{if (sex2 == "famale")
    {
        Console.WriteLine("Ewa lat 33");
    }
;

}
bool isActice3 = true;
if (age3 > 18)
{

    Console.WriteLine("Zofia kobieta pełnoletnia");

}
else if (age3 < 18)
{
    Console.WriteLine("Zofia Kobieta niepełnoletnia");
}
