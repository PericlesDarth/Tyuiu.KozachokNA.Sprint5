using Sprint5.Lib;

namespace Tyuiu.KozachokNA.Sprint5.Task0.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foo = DataService.func(2);
            Console.WriteLine(foo);
            string name = "OutPutFileTask0.txt";
            MyIO.myOutput(name, Convert.ToString(foo));
        }
    }
}
