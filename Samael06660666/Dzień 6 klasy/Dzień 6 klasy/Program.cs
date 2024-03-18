using Dzień_6_klasy;

User user1 = new User("Łukasz", "Alpha", 30);
User user2 = new User("Krzysiek", "Bravo", 57);
User user3 = new User("Janek", "Charlie", 78);
User user4 = new User("Filip", "Delta", 27);

        user1.AddScore([1, 5, 8, 6, 4]);
        user2.AddScore([9, 1, 5, 7, 6]);
        user3.AddScore([1, 3, 9, 8, 5]);
        user4.AddScore([6, 7, 4, 8, 2]);

        List<User> employees = new List<User> { user1, user2, user3, user4 };
        int bestScore = 0;
        User? bestEmployee = null;

        foreach (var employee in employees)
        {
            if (employee.Result > bestScore)
            {
                bestScore = employee.Result;
                bestEmployee = employee;
            }
        }