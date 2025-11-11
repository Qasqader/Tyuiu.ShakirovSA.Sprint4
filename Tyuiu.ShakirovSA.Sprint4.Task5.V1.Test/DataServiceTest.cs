using Tyuiu.ShakirovSA.Sprint4.Task5.V1.Lib;
namespace Tyuiu.ShakirovSA.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matr = { { 2, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            int[,] res = ds.Calculate(matr);
            int[,] wait = { { 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
