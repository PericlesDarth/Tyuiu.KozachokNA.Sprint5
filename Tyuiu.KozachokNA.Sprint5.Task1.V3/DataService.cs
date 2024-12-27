using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint5.Task1.V3
{
    internal class DataService
    {
        static double func(double x)
        {
            double res = Math.Cos(2 * x) + Math.Sin(x) / (x + 2.5) + 2 * x;
            return res;
        }
        static double[] ArrayOfValues(int a, int b)
        {
            int l = b - a + 1;
            double[] result = new double[l];
            for (int i = 0; i < l; i++)
            {
                if (i != -2.5)
                {
                    result[i] = func(i + a);
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }
        public static string[] TabulatedOutput(int a, int b)
        {
            double[] foo = ArrayOfValues(a, b);
            string[] bar = new string[foo.Length];

            for (int i = 0; i < foo.Length; i++)
            {
                if (i + a < 0)
                {
                    bar[i] = Convert.ToString(i + a) + ": " + Convert.ToString(foo[i]);
                }
                else
                {
                    bar[i] = " " + Convert.ToString(i + a) + ": " + Convert.ToString(foo[i]);
                }
            }
            return bar;
        }
    }
}
