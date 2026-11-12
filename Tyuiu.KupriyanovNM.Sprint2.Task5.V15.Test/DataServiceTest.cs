using Tyuiu.KupriyanovNM.Sprint2.Task5.V15.Lib;
namespace Tyuiu.KupriyanovNM.Sprint2.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindDayName_ReturnsCorrectDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1));
            Assert.AreEqual("Вторник", ds.FindDayName(2));
            Assert.AreEqual("Среда", ds.FindDayName(3));
            Assert.AreEqual("Четверг", ds.FindDayName(4));
            Assert.AreEqual("Пятница", ds.FindDayName(5));
            Assert.AreEqual("Суббота", ds.FindDayName(6));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));

            Assert.AreEqual("Понедельник", ds.FindDayName(8));
            Assert.AreEqual("Воскресенье", ds.FindDayName(14));
            Assert.AreEqual("Понедельник", ds.FindDayName(365));
        }

        [TestMethod]
        public void FindDayName_ThrowsExceptionForLessThanOne()
        {
            DataService ds = new DataService();

            try
            {
                ds.FindDayName(0);
                Assert.Fail("Исключение не было вызвано");
            }
            catch (ArgumentException)
            {
                // Тест пройден
            }
        }

        [TestMethod]
        public void FindDayName_ThrowsExceptionForMoreThan365()
        {
            DataService ds = new DataService();

            try
            {
                ds.FindDayName(366);
                Assert.Fail("Исключение не было вызвано");
            }
            catch (ArgumentException)
            {
                // Тест пройден
            }
        }

        [TestMethod]
        public void FindDayName_ThrowsExceptionForNegativeNumber()
        {
            DataService ds = new DataService();

            try
            {
                ds.FindDayName(-1);
                Assert.Fail("Исключение не было вызвано");
            }
            catch (ArgumentException)
            {
                // Тест пройден
            }
        }
    }
}
