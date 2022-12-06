using CalculatorConundrum;
namespace CalculatorConundrum.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // SimpleCalculator calc = new SimpleCalculator(); // creat object
           var result =  SimpleCalculator.Calculate(16, 51, "+");
            Assert.AreEqual(result, "16 + 51 = 67");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                SimpleCalculator.Calculate(100, 10, "-");
            });
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                SimpleCalculator.Calculate(8, 2, "");
            });
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                SimpleCalculator.Calculate(58, 6, null);
            });
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = SimpleCalculator.Calculate(512, 0, "/");
            Assert.AreEqual(result, "Division by zero is not allowed.");
        }


    }
}