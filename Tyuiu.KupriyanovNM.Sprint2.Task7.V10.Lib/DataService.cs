using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KupriyanovNM.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool result;

            if (x >= 0)
            {
                result = y >= Math.Pow(x, 2) - 2 && y <= x;
            }
            else
            {
                result = y >= Math.Pow(x, 2) - 2 && y <= -x;
            }

            return result;
        }
    }
}
