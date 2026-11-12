using Tyuiu.KupriyanovNM.Sprint2.Task2.V23.Lib;
namespace Tyuiu.KupriyanovNM.Sprint2.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 4;
            int y = 4;

            bool result = ds.CheckDotInShadedArea(x, y);

            bool expected = true;

            Assert.AreEqual(expected, result);
        }
    }
}
