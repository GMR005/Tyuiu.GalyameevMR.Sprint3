using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint3.Task4.V9.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 2. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #4                                                     ");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах      ");
            Console.WriteLine("* Задание #4                                                    ");
            Console.WriteLine("* Вариант #9                                                    ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("На отрезке, где x принимает значения от -5 до 5, вычислить значение " +
                "функции y=x/(cos(x) - x)");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("x => -5 && x <=5 && x++");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("y=x/(cos(x) - x");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            double res = DataService.Calculate(-5, 5);
            Console.WriteLine(res);
        }
    }
}
