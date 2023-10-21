using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalyameevMR.Sprint3.Task2.V27.Lib
{
    public class DataService : ISprint3Task2V27
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            startValue = 1;
            stopValue = 14;
            double sum = 0.0;
            int x = 5;
            int i = startValue;
            value = 4 / (1 + Math.Pow(x, i));
            do
            {
                double res = Math.Pow(value, i);
                res = Math.Round(res, 3);
                sum += res;
                i++;
            }
            while (i <= stopValue);
            sum = Math.Round(sum, 3);
            return sum;
        }
    }
}
