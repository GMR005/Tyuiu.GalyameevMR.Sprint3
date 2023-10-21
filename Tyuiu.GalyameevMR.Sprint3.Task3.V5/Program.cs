using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint3.Task3.V5.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task3.V5
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
            Console.WriteLine("* Задание #3                                              ");
            Console.WriteLine("* Вариант #5                                           ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Написать программу, используя цикл foreach, которая заменяет " +
                "буквы a  на * в строке: fifa al fall"); 
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("fifa al fall");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            string res = DataService.ReplaceCharInString("fifa al fall", 'a', '*');
            Console.WriteLine(res);
        }
    }
}
