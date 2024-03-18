using Dzień_6_klasy;

internal class ScoreProgram
{
    private static void Main(string[] args)
    {
        Employee employee1 = new Employee("Łukasz", "Alpha", 30);
        Employee employee2 = new Employee("Krzysiek", "Bravo", 57);
        Employee employee3 = new Employee("Janek", "Charlie", 78);
        Employee employee4 = new Employee("Filip", "Delta", 27);

        employee1.AddScore([1, 5, 8, 6, 4]);
        employee2.AddScore([9, 1, 5, 7, 6]);
        employee3.AddScore([1, 3, 9, 8, 5]);
        employee4.AddScore([6, 7, 4, 8, 2]);

        List<Employee> employees = new List<Employee> { employee1, employee2, employee3, employee4 };
        int bestScore = 0;
        Employee? bestEmployee = null;

        foreach (var employee in employees)
        {
            if (employee.Result > bestScore)
            {
                bestScore = employee.Result;
                bestEmployee = employee;
            }
        }
        Console.WriteLine($"Pracowniek miesiąca (Najlepszy wynik) - {bestEmployee.FirstName} {bestEmployee.LastName}, z Wynikiem {bestScore}!");
    }   
}

