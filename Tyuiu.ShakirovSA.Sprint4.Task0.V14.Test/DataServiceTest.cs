using Tyuiu.ShakirovSA.Sprint4.Task0.V14.Lib;
namespace Tyuiu.ShakirovSA.Sprint4.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            int[] list = {8, 9, 5, 4, 3, 2, 1, 0, 5, 7};
            int res = ds.GetSumOddArrEl(list);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
