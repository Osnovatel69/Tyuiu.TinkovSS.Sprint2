using System;
using System.Text;
using Tyuiu.TinkovSS.Sprint2.Task0.V28.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task0.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Тинков С. С.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнения и арифметических выражений.    *");
            Console.WriteLine("* Порядок операций: ==, !=, <, >, <=, >=.                                  *");
            Console.WriteLine("* Получить массив: (False, False, False, False, False, False)               *");
            Console.WriteLine("* при x = 111 и y = 735.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 111;
            int y = 735;

            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);

            DataService dataService = new DataService();
            bool[] result = dataService.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("(" + string.Join(", ", result) + ")");

            Console.WriteLine();
            Console.WriteLine("Нажмите Enter для завершения...");
            Console.ReadLine();
        }
    }
}