using Sprint5.Lib;

namespace Tyuiu.KozachokNA.Sprint5.Task1.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] foo = DataService.TabulatedOutput(-5, 5);
            for (int i = 0; i < foo.Length; i++)
            {
                Console.WriteLine(foo[i]);
            }
            MyIO.multiLineOutput("OutPutFileTask1.txt", foo);
        }
    }
}
