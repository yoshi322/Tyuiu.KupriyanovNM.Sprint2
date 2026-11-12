using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KupriyanovNM.Sprint2.Task2.V23.Lib
{
    public class DataService : ISprint2Task2V23
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            

            if (x > 2 && x < 6 && y > 2 && y < 5)
            {
                res = true;
            }

            
            if (x > 8 && x < 12 && y > 2 && y < 5)
            {
                res = true;
            }

            
            if (x > 2 && x < 12 && y > 4 && y < 6)
            {
                res = true;
            }

            
            if (x > 6 && x < 13 && y > 5 && y < 9)
            {
                res = true;
            }

            
            if (x > 5 && x < 12 && y > 8 && y < 11)
            {
                res = true;
            }

            
            if (x > 2 && x < 6 && y > 10 && y < 12)
            {
                res = true;
            }

            
            if (x > 6 && x < 11 && y > 10 && y < 13)
            {
                res = true;
            }

            
            if (x > 11 && x < 14 && y > 11 && y < 13)
            {
                res = true;
            }

            return res;
        }
    }
}
