using Tyuiu.KupriyanovNM.Sprint2.Task7.V10.Lib;
namespace Tyuiu.KupriyanovNM.Sprint2.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Спринт #2 | Выполнил: Куприянов Н. М. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Никита Максимович | ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("* X,Y в заштрихованной области.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (result)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
