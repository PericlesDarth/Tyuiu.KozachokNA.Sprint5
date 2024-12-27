using Sprint5.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tyuiu.KozachokNA.Sprint5.Task7.V9
{
    internal class DataService
    {
        public static string DeleteUppers(string s)
        {
            Regex regex = new Regex(@"[^A-Z]");
            MatchCollection matches = regex.Matches(s);
            string foo = "";
            for (int i = 0; i < matches.Count; i++)
            {
                foo += matches[i].Value;
            }
            return foo;
        }
    }
}
