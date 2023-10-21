using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint3.Task2.V27.Lib;
namespace Tyuiu.GalyameevMR.Sprint3.Task2.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 2. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #3                                                    ");
            Console.WriteLine("* Тема: цикл while                                        ");
            Console.WriteLine("* Задание #2                                             ");
            Console.WriteLine("* Вариант #27                                          ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Написать программу используя цикл do...while, которая вычисляет " +
                "сумму ряда по формуле.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("i => 1 && i <= 14");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            double sum = DataService.GetSumSeries(0.667, 1, 14);
            Console.WriteLine(sum);
        }
    }
}
