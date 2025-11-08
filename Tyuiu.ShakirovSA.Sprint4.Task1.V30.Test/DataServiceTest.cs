using Tyuiu.ShakirovSA.Sprint4.Task1.V30.Lib;
namespace Tyuiu.ShakirovSA.Sprint4.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            int[] list = { 6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7 };
            int res = ds.Calculate(list);
            int wait = 13824;
            Assert.AreEqual(res, wait);
        }
    }
}
