using Tyuiu.ShakirovSA.Sprint4.Task7.V7.Lib;
namespace Tyuiu.ShakirovSA.Sprint4.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 5;
            int res = ds.Calculate(4, 2, "31415926");
            Assert.AreEqual(wait, res);
        }
    }
}
