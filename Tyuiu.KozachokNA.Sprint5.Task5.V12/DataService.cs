using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint5.Task5.V12
{
    internal class DataService
    {
        public static (double, double) Summation(string foo)
        {
            double plus, minus, num;
            plus = 0;
            minus = 0;

            string[] bar = foo.Replace('.', ',').Split(' ');
            foreach (string s in bar)
            {
                num = double.Parse(s);
                if (num < 0)
                {
                    minus += num;
                }
                else
                {
                    plus += num;
                }
            }
            return (Math.Round(plus - minus, 3), Math.Round(plus - Math.Abs(minus), 3));
        }
    }
}
