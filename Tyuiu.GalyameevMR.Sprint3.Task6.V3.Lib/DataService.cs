using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GalyameevMR.Sprint3.Task6.V3.Lib
{
    public class DataService : ISprint3Task6V0
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            startValue = 13;
            stopValue = 19;
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 1; d <= i; d++)
                {
                    if (i % d == 0)
                    {
                        if (d > 8)
                        {
                            sum += d;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
