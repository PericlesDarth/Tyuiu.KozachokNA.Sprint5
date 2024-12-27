using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint5.Task2.V11
{
    internal class DataService
    {
        static int[,] InputArray(int a, int b)
        {
            int[,] ints = new int[a, b];
            string s = "";
            string[] foo = new string[b];
            for (int i = 0; i < a; i++)
            {
                s = Console.ReadLine();
                foo = s.Split("; ");
                for (int j = 0; j < b; j++)
                {
                    ints[i, j] = int.Parse(foo[j]);
                }
            }
            return ints;
        }
        static int[,] UpdateArray(int[,] ints)
        {
            int a, b;
            a = ints.GetLength(0);
            b = ints.GetLength(1);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (ints[i, j] % 2 == 1)
                    {
                        ints[i, j] = 0;
                    }
                }
            }
            return ints;
        }

        public static string[] OutputArray(int a, int b)
        {
            string[] res = new string[a];
            int[,] ints = UpdateArray(InputArray(a, b));
            string foo = "";
            for (int i = 0; i < a; i++)
            {
                foo = "";
                for (int j = 0; j < b; j++)
                {
                    if (j < b)
                    {
                        foo += Convert.ToString(ints[i, j]) + "; ";
                    }
                    else
                    {
                        foo += Convert.ToString(ints[i, j]);
                    }
                }
                res[i] = foo;
            }
            return res;
        }
    }
}
