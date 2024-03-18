using Dzień_6_klasy;

namespace ChellangeApp_Dzień6_7_TestProject1
{
    public class Tests
    {
        [Test]
        public void TotalScoring()
        {
            // arrenge (przygotowanie)
            var user = new User("Łukasz", "Alpha", 30);
            user.AddScore(5);
            user.AddScore(6);

            // act (działanie)
            var result = user.Result;

            // assert
            Assert.AreEqual(11, result);
        }
        [Test]
        public void TotalScoring2()
        {
            // arrenge (przygotowanie)
            var user = new User("Krzysiek", "Bravo", 57);
            user.AddScore(-3);
            user.AddScore(-7);

            // act (działanie)
            var result = user.Result;

            // assert
            Assert.AreEqual(-10, result);
        }
        [Test]
        public void TotalScoring3()
        {
            // arrenge (przygotowanie)
            var user = new User("Janek", "Charlie", 78);
            user.AddScore(5);
            user.AddScore(-3);

            // act (działanie)
            var result = user.Result;

            // assert
            Assert.AreEqual(2, result);
        }
    }

}