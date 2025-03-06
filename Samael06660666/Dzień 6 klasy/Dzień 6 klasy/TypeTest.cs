namespace Dzień_6_klasy
{
    public class TypeTest
    {
        [Test]
        public void AreTwonumberNotEqual()
        {
            int number1 = 1;
            int number2 = 2;
            //Assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void AreTwoFLoatEqual()
        {
            float number1 = 4.2f;
            float number2 = 4.2f;
            //Assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void IsFloatEqualToInteger()
        {
            float number1 = 9.5f;
            int number2 = 9;
            //Assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void AreTwoObjectNotEqual()
        {
            var User1 = GetEmployee("Alex");
            var User2 = GetEmployee("Alex");
            //Assert
            Assert.AreNotEqual(User1, User2);
        }
        [Test]
        public void AreTwoStringsEqual()
        {
            var User1 = GetUser("Alex");
            var User2 = GetUser("Alex");
            Assert.AreEqual(User1, User2);
        }


        private User GetUser(string name)
        {
            return new User(name);
        }

        private class Assert
        {
            internal static void AreEqual(float number1, float number2)
            {
                throw new NotImplementedException();
            }

            internal static void AreEqual(User user1, User user2)
            {
                throw new NotImplementedException();
            }

            internal static void AreNotEqual(int number1, int number2)
            {
                throw new NotImplementedException();
            }

            internal static void AreNotEqual(User user1, User user2)
            {
                throw new NotImplementedException();
            }
        }
        private User GetEmployee(string name)
        {
            return new User(name);
        }

    }


}

