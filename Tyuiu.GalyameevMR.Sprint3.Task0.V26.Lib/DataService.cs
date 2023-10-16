using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalyameevMR.Sprint3. Task0.V26.Lib
{
    public class DataService : ISprint3Task0V26
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double proiz = 1.0;
            startValue = 1;
            stopValue = 9;
            for (int k = startValue; k <= stopValue; k++)
            {
                value = Math.Pow(2, k) * Math.Cos(1.80) / (k + 1);
                proiz *= value;
            }
            proiz = Math.Round(proiz, 3);
            return proiz;    
        }
    }
}
