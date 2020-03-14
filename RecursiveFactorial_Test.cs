using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RecursiveFactorial_Test
{
    [TestClass]
    public class RecursiveFactorial_Test
    {
        [TestMethod]
        public void PositiveInteger()
        {
            int expected = 120;
            int input = 5;
            //Act
            int actual = RecursiveFactorial.FindNthFactorial(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeInteger()
        {
            int expected = -120;
            int input = -5;
            //Act
            int actual = RecursiveFactorial.FindNthFactorial(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zero()
        {
            int expected = 1;
            int input = 0;
            //Act
            int actual = RecursiveFactorial.FindNthFactorial(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
