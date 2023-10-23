using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalyameevMR.Sprint3.Task4.V9.Lib
{
    public class DataService : ISprint3Task4V9
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y;
            startValue = -5;
            stopValue = 5;
            double mult = 1.0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                y = x / (Math.Cos(x) - x);
                mult *= y;
                x++;
            }
            mult = Math.Round(mult, 3);
            return mult;
        }
    }
}
