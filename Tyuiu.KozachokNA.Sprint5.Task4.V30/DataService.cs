using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint5.Task4.V30
{
    internal class DataService
    {
        public static double func(double x)
        {
            double res = Math.Pow(x, 3) - Math.Tan(x) + 2.03 * x;
            return Math.Round(res);
        }
    }
}
