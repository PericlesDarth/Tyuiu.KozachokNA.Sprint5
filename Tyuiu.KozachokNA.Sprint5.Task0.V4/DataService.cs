using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint5.Task0.V4
{
    internal class DataService
    {
        public static double func(double x)
        {
            double res = 2 * Math.Pow(x, 3) + Math.Pow(x, 2) / 2 - 3.5 * x + 2;
            return Math.Round(res, 3);
        }
    }
}
