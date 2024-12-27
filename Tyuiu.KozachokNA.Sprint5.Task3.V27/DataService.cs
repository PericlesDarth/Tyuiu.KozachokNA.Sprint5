using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint5.Task3.V27
{
    internal class DataService
    {
        public static double func (double x)
        {
            double foo = Math.Pow(x - 1, 3 * x + 1);
            return Math.Round(foo, 3);
        }
    }
}
