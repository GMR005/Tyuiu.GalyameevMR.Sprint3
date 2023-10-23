using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalyameevMR.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            x = 5;
            startValue1 = startValue2 = 1;
            stopValue1 = 3;
            stopValue2 = 6;
            double sum = 0.0;
            double value;
            for (int i = startValue1; i <= stopValue1; i++)
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    value = Math.Pow((x / Math.Sin(x)), k);
                    sum += value;
                }
            sum = Math.Round(sum, 3);
            return sum;

        }
    }
}
