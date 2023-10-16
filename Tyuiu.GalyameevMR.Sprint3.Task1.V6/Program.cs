using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint3.Task1.V6.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task1.V6
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
            Console.WriteLine("* Задание #1                                             ");
            Console.WriteLine("* Вариант #6                                          ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Написать программу используя цикл while, которая вычисляет " +
                "сумму ряда по формуле.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("k => 1 && k <= 10");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            double sum = DataService.GetMultiplySeries(1, 10);
            Console.WriteLine(sum);

        }
    }
}
