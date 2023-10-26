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
            int size = stopValue - startValue + 1;
            double[] tab = new double[size];
            int i = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double checkToZero = 2 - x;
                double value;

                if (Math.Abs(checkToZero) < double.Epsilon)
                {
                    value = 0;
                }
                else
                {
                    value = Math.Sin(x) + ((Math.Cos(x) + 1) / checkToZero) + 2 * x;
                }

                tab[i] = Math.Round(value, 3);
                i++;
            }

            return tab;
        }
    }
}
