using Tyuiu.ShakirovSA.Sprint4.Task2.V2.Lib;
namespace Tyuiu.ShakirovSA.Sprint4.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            int[] nums = { 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 3 };
            int res = ds.Calculate(nums);
            int wait = 3;
            Assert.AreEqual(res, wait);
        }
    }
}
