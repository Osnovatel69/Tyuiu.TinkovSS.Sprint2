using System;
using Tyuiu.YourSurnameII.Sprint2.Task0.V28.Lib;

namespace Tyuiu.YourSurnameII.Sprint2.Task0.V28
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Спринт 2 | Задание 0 | Вариант 28";

            Console.WriteLine(
                "***********************************************************************");
            Console.WriteLine(
                "* Спринт #2                                                           *");
            Console.WriteLine(
                "* Тема: Операции сравнения                                            *");
            Console.WriteLine(
                "* Задание #0                                                         *");
            Console.WriteLine(
                "* Вариант #28                                                        *");
            Console.WriteLine(
                "***********************************************************************");

            Console.WriteLine("* УСЛОВИЕ:");
            Console.WriteLine("* Используя сравнения ==, !=, <, >, <=, >= в указанном");
            Console.WriteLine("* порядке и арифметические выражения, получить массив");
            Console.WriteLine("* (False, False, False, False, False, False)");
            Console.WriteLine("* при x = 111 и y = 735.");

            Console.WriteLine(
                "***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");

            int x = 111;
            int y = 735;

            Console.WriteLine($"* x = {x}");
            Console.WriteLine($"* y = {y}");

            DataService dataService = new DataService();
            bool[] result = dataService.GetCompareOperations(x, y);

            Console.WriteLine(
                "***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine($"* ({string.Join(", ", result)})");
            Console.WriteLine(
                "***********************************************************************");

            Console.WriteLine("Нажмите Enter для завершения...");
            Console.ReadLine();
        }
    }
}