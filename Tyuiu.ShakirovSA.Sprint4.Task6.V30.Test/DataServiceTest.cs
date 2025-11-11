using Tyuiu.ShakirovSA.Sprint4.Task6.V30.Lib;
namespace Tyuiu.ShakirovSA.Sprint4.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mass = { "Берёза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
            string[] res = ds.Calculate(mass);
            string[] wait = { "Берёза" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
