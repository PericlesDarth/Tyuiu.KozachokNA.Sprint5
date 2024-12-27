using Sprint5.Lib;

namespace Tyuiu.KozachokNA.Sprint5.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] foo = DataService.OutputArray(3, 3);
            foreach (string s in foo)
            {
                Console.WriteLine(s);
            }
            MyIO.multiLineOutput("OutPutFileTask2.csv", foo);
        }
    }
}
