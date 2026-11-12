using Tyuiu.KupriyanovNM.Sprint2.Task0.V21.Lib;
namespace Tyuiu.KupriyanovNM.Sprint2.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService dataService = new DataService();

            int x = 1705;
            int y = 775;

            bool[] result = dataService.GetCompareOperations(x, y);

            bool[] expected =
            {
                false,
                false,
                false,
                false,
                false,
                false
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
