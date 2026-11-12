using Tyuiu.KupriyanovNM.Sprint2.Task6.V12.Lib;
namespace Tyuiu.KupriyanovNM.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("2024.1.31",
                ds.FindDateOfPreviousDay(2024, 2, 1));

            Assert.AreEqual("2024.2.28",
                ds.FindDateOfPreviousDay(2024, 2, 29));

            Assert.AreEqual("2024.2.29",
                ds.FindDateOfPreviousDay(2024, 3, 1));

            Assert.AreEqual("2024.4.30",
                ds.FindDateOfPreviousDay(2024, 5, 1));

            Assert.AreEqual("2024.12.31",
                ds.FindDateOfPreviousDay(2025, 1, 1));
        }

        [TestMethod]
        public void FindDateOfPreviousDay_ThrowsExceptionForWrongMonth()
        {
            DataService ds = new DataService();

            try
            {
                ds.FindDateOfPreviousDay(2024, 13, 1);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                // тест пройден
            }
        }

        [TestMethod]
        public void FindDateOfPreviousDay_ThrowsExceptionForWrongDay()
        {
            DataService ds = new DataService();

            try
            {
                ds.FindDateOfPreviousDay(2024, 4, 31);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                // тест пройден
            }
        }

        [TestMethod]
        public void FindDateOfPreviousDay_ThrowsExceptionForZeroDay()
        {
            DataService ds = new DataService();

            try
            {
                ds.FindDateOfPreviousDay(2024, 1, 0);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
                // тест пройден
            }
        }
    }
}
