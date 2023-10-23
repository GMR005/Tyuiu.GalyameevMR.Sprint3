using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalyameevMR.Sprint3.Task3.V5.Lib
{
    public class DataService : ISprint3Task3V5
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            value = "fifa al fall";    
            replaceable = 'a';
            foreach (char ch in value)
            {
                if (ch == replaceable)
                {
                    value = value.Replace(ch, '*');
                }
            }
            return value;
        }
    }
}
