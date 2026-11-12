using Tyuiu.KupriyanovNM.Sprint2.Task4.V19.Lib;
namespace Tyuiu.KupriyanovNM.Sprint2.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 10;

            double res = ds.Calculate(x, y);
            double wait = 6.04;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 10;
            double y = 10;

            double res = ds.Calculate(x, y);
            double wait = 0.978;

            Assert.AreEqual(wait, res);
        }
    }
}
