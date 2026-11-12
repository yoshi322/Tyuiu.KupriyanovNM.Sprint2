using Tyuiu.KupriyanovNM.Sprint2.Task1.V2.Lib;
namespace Tyuiu.KupriyanovNM.Sprint2.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int a = 135;
            int b = 156;
            int c = 154;
            int d = 174;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            bool[] expected = { true, true, true, true, true, false };

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
