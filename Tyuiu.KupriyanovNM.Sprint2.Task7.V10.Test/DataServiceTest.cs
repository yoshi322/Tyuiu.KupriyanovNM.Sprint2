using Tyuiu.KupriyanovNM.Sprint2.Task7.V10.Lib;
namespace Tyuiu.KupriyanovNM.Sprint2.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, -1));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(1, 0));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-1, 0));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(1, 1));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-1, 1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            // Нижняя граница — парабола y = x^2 - 2
            Assert.AreEqual(true,
                ds.CheckDotInShadedArea(0, -2));

            // Правая граница — прямая y = x
            Assert.AreEqual(true,
                ds.CheckDotInShadedArea(2, 2));

            // Левая граница — прямая y = -x
            Assert.AreEqual(true,
                ds.CheckDotInShadedArea(-2, 2));

            // Точка пересечения прямых
            Assert.AreEqual(true,
                ds.CheckDotInShadedArea(0, 0));
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();

            Assert.AreEqual(false, ds.CheckDotInShadedArea(0, 1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0, -3));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, 2));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(-1, 2));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(3, 3));
        }
    }
}
