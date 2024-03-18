using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void AreTwoNumbersNotEqual()
        {
            int number1 = 1;
            int number2 = 2;
            //Assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void AreTwoFloatEqual()
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
            float number2 = 9;
            //Assert
            Assert.AreNotEqual(number1, number2);
        }
        
    }
}