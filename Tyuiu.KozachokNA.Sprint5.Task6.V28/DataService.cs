using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint5.Task6.V28
{
    internal class DataService
    {
        public static int CountFourDigits(string s)
        {
            int res = 0;
            string[] foo = s.Split(' ');
            foreach (string bar in foo)
            {
                if (bar.Length == 4 && char.IsDigit(bar[0]))
                {
                    res++;
                }
            }
            return res;
        }
    }
}
