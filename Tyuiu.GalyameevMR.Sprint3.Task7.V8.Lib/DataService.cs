using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalyameevMR.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V0
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            startValue = -5;
            stopValue = 5;
            int i = 0;
            double[] tab = new double[11];
            double value;
            for (int x = startValue; x <= stopValue; x++)
            {
                value = Math.Round(Math.Sin(x) + ((Math.Cos(x) + 1) / 2 - x) + 2 * x, 3);
                if (x == 2)
                {
                    value = 0;
                }
                value = tab[i];
                i++;
            }
            return tab;
        }
    }
}
