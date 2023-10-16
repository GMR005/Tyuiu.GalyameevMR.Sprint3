using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint3.Task0.V26. Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task0.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 2. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #3                                                    ");
            Console.WriteLine("* Тема: цикл for                                         ");
            Console.WriteLine("* Задание #0                                             ");
            Console.WriteLine("* Вариант #26                                            ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Написать программу используя цикл for, которая вычисляет " +
                "произведение ряда по формуле.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("k => 1 && k <= 9");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            
            double res = DataService.GetSumSeries(-0.2272020947, 1, 9);
            Console.WriteLine(res);
        }
    }
    
}
