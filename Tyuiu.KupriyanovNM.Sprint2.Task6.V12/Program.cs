using Tyuiu.KupriyanovNM.Sprint2.Task6.V12.Lib;
namespace Tyuiu.KupriyanovNM.Sprint2.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Куприянов Н. М. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Никита Максимович | ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string result;

            try
            {
                result = "Дата предыдущего дня: "
                    + ds.FindDateOfPreviousDay(g, m, n);
            }
            catch (ArgumentException)
            {
                result = "Введена неверная дата.";
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
