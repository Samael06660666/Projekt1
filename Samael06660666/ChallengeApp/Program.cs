using ChallengeApp;

User user1 = new User("Alex", "123");
User user2 = new User("Buba", "345");
User user3 = new User("Rafael", "567");
User user4 = new User("Dziochy", "789");

int bestScore = 0;
User? bestUser = null;

List<User> users = new List<User> { user1, user2, user3, user4 };

user1.AddScore(7);
user1.AddScore(6);
user1.AddScore(9);
user1.AddScore(-3);

user2.AddScore(2);
user2.AddScore(-3);
user2.AddScore(5);
user2.AddScore(-1);

user3.AddScore(6);
user3.AddScore(6);
user3.AddScore(6);
user3.AddScore(0);

user4.AddScore(9);
user4.AddScore(4);
user4.AddScore(0);
user4.AddScore(-2);



foreach (var user in users)
{
    if (user.Result > bestScore)
    {
        bestScore = user.Result;
        bestUser = user;
    }
}
Console.WriteLine($"Pracownik miesiaca (Najlepszy wynik) - {bestUser.Login}, z wynikiem {bestScore}!");