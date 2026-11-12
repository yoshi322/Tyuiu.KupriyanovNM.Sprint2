using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KupriyanovNM.Sprint2.Task4.V19.Lib
{
    public class DataService : ISprint2Task4V19
    {
        public double Calculate(double x, double y)
        {
            double z;

            if (x / 2 < y - 6)
            {
                z = Math.Pow(6 + 4 / Math.Pow(y, 2), x);
            }
            else
            {
                z = (Math.Pow(x, 2) - Math.Cos(y * y) + 10) /
                    (Math.Pow(y, 2) - Math.Sin(y * y) + 12);
            }

            return Math.Round(z, 3);
        }
    }
}
