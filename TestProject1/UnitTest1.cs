using Task0;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator calcRif = new Calculator(); // test comment
            int result = calcRif.add(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}