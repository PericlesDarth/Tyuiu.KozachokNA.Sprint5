using Sprint5.Lib;

namespace Tyuiu.KozachokNA.Sprint5.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foo = DataService.func(3);
            Console.WriteLine(foo);
            MyIO.myOutput("OutPutFileTask3.bin", Convert.ToString(foo));
        }
    }
}
