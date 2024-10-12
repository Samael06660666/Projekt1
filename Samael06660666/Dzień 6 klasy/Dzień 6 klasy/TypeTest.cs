
namespace Dzień_6_klasy
{
    public class TypeTest
    {

        [Test]
        public void TEST()
        {
            int number1 = 1;
            int number2 = 2;
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void GetUserShouldReturnDifferentObects()
        {
            var user1 = GetUser("Alex");
            var user2 = GetUser("łukasz");
            Assert.AreNotEqual(user1, user2);
        }


        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
