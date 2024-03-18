namespace ChellangeApp_Dzień6_7_TestProject1
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrenge (przygotowanie)
            var user =new User("Alex", "l34hh5");
            user.AddScore(5);
            user.AddScore(6);

            // act (działanie)
            var result = user.Result;

            // assert
            Assert.AreEqual(11, result);
        }
    }
}