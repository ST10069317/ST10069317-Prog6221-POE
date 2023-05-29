using ST10069317_Paballo_Ranoto_;
namespace TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLimit()
        {
            int balance = 150;
            int limit = 100;
            int expectedBalance = 50;

            Logic logic = new Logic();

            logic.LimitBalance = balance;
            logic.checkLImit(limit);
            int actualBalance = logic.LimitBalance;
            Assert.AreEqual(expectedBalance, actualBalance);
        }
        public void TestMethod2()
        {
            int theLIMIT = 300;
            Logic logic = new Logic();

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => logic.checkLImit(theLIMIT));
        }

    }
}
