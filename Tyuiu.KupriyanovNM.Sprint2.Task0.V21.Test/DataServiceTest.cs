using Tyuiu.KupriyanovNM.Sprint2.Task0.V21.Lib;
namespace Tyuiu.KupriyanovNM.Sprint2.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            bool[] result = ds.GetCompareOperations(1705, 775);
            bool[] expected = new bool[6]
            {
                false, false, false, false, false, false
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
