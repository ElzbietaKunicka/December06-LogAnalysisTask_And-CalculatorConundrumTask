using December06;
namespace December06Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // => returns "File Deleted."
            
            //Arrange sukuriam kimtamuosius
            var log = "[INFO]: File Deleted.";
            //Act 
            var result = log.SubstringAfter(": ");
            //Assert pats testas
            Assert.AreEqual(result, "File Deleted.");
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange sukuriam kimtamuosius
            var log = "[INFO]: File Deleted.";
            //Act 
            var result = log.SubstringBetween("[", "]"); 
            //Assert pats testas
            Assert.AreEqual(result, "INFO");
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange sukuriam kimtamuosius
            var log = "[ERROR]: Missing ; on line 20.";
            //Act 
            var result = log.Message(); 
            //Assert pats testas
            Assert.AreEqual(result, "Missing ; on line 20.");
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange sukuriam kimtamuosius
            var log = "[ERROR]: Missing ; on line 20.";
            //Act 
            var result = log.LogLevel(); 
            //Assert pats testas
            Assert.AreEqual(result, "ERROR");
        }
    }
}