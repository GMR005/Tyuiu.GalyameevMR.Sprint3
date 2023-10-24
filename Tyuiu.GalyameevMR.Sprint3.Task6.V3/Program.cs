using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint3.Task6.V3.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 3. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #3                                                     ");
            Console.WriteLine("* Тема: Обработка целочисленной информации                      ");
            Console.WriteLine("* Задание #6                                                    ");
            Console.WriteLine("* Вариант #3                                                    ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Напишите программу, которая ищет среди целых чисел, принадлежащих " +
                "числовому отрезку [13, 19] сумму всех делителей больше 8");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*d > 8, N >= 13 && N <= 19");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            int sum = DataService.GetSumTheDivisors(13, 19);
            Console.WriteLine(sum);
        }
    }
}
