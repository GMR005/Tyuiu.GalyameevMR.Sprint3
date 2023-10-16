using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalyameevMR.Sprint3.Task1.V6.Lib
{
    public class DataService : ISprint3Task1V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double value;
            int k = 1;
            double sum = 0;
            while (k <= 10)
            {
                value = Math.Sin(k) * (Math.Pow(4, k) + 1);
                sum += value;
                k++;
            }
            sum = Math.Round(sum, 3);
            return sum;
        }
    }
}
