using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KupriyanovNM.Sprint2.Task0.V21.Lib
{
    public class DataService : ISprint2Task0V21
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = x + 1 == y;       // ==
            result[1] = x - 930 != y;     // !=
            result[2] = x < y;            // <
            result[3] = x - 1000 > y;     // >
            result[4] = x + 1 <= y;       // <=
            result[5] = x - 1000 >= y;    // >=

            return result;
        }
    }
}
