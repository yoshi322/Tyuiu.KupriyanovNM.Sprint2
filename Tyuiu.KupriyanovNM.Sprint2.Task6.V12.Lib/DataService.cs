using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KupriyanovNM.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (g < 1)
            {
                throw new ArgumentException();
            }

            if (m < 1 || m > 12)
            {
                throw new ArgumentException();
            }

            int daysInMonth;

            switch (m)
            {
                case 2:
                    daysInMonth = 29;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;

                default:
                    daysInMonth = 31;
                    break;
            }

            if (n < 1 || n > daysInMonth)
            {
                throw new ArgumentException("неверное число месяца");
            }

            if (n > 1)
            {
                n--;
            }
            else
            {
                if (m > 1)
                {
                    m--;

                    switch (m)
                    {
                        case 2:
                            n = 29;
                            break;

                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            n = 30;
                            break;

                        default:
                            n = 31;
                            break;
                    }
                }
                else
                {
                    g--;
                    m = 12;
                    n = 31;
                }
            }

            return g + "." + m + "." + n;
        }
    }
}
