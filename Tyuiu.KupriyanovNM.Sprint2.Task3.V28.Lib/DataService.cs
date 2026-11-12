using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KupriyanovNM.Sprint2.Task3.V28.Lib
{
    public class DataService : ISprint2Task3V28
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                y = x + Math.Pow(Math.Cos(x * x) / (x - 1), x + 3);
            }
            else
            {
                if (x == 0)
                {
                    y = (x * x + Math.Cos(x * x) - 11) /
                        (x * x - Math.Sin(x * x) + 2);
                }
                else
                {
                    if (x > -32 && x < -1)
                    {
                        y = Math.Pow(Math.Cos(x) / (Math.PI - x), 2);
                    }
                    else
                    {
                        if (x < -32)
                        {
                            y = x + 10 * x - 7 / x;
                        }
                        else
                        {
                            y = double.NaN;
                        }
                    }
                }
            }

            return Math.Round(y, 3);
        }
    }
}
