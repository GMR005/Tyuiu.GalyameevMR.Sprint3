using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint3.Task7.V8.Lib;

namespace Tyuiu.GalyameevMR.Sprint3.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 2. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #45                                                    ");
            Console.WriteLine("* Тема: Вложенные циклы                                         ");
            Console.WriteLine("* Задание #7                                                    ");
            Console.WriteLine("* Вариант #8                                                    ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("*Написать программу, которая выводит значение функции на экран  ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("------------------------");
            Console.WriteLine("|    x    |    f(x)    |");
            Console.WriteLine("------------------------");
            double[] array = DataService.GetMassFunction(-5, 5);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"| {startValue,7:F} | {array[i],10:F3} |");
                startValue++;
            }
            Console.WriteLine("+----------+-----------+");
        }
    }
}
