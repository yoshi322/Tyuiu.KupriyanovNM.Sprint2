using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KupriyanovNM.Sprint2.Task0.V21.Lib
{
    public class DataService : ISprint2Task0V21
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = x == y;
            result[1] = x != x;
            result[2] = x < y;
            result[3] = x - y > x;
            result[4] = x <= y;
            result[5] = x - y >= x; // abc

            return result;
        }
    }
}
