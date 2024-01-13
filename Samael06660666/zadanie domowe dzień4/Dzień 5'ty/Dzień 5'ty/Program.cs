using System.Numerics;

int number = 20301640; 
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

Console.WriteLine("liczba:" + number);

for (int i=0;i<10;i++)
{
    int numberTotal = 0;
    foreach (char c in letters)
    {
        if (i.ToString() == c.ToString())
        numberTotal++;
    }
    Console.WriteLine(i + " => " + numberTotal);
}
