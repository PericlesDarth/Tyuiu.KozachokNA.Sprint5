using Sprint5.Lib;

namespace Tyuiu.KozachokNA.Sprint5.Task4.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string foo = MyIO.myInput("InPutDataFileTask4V30.txt");
            double x = Convert.ToDouble(foo.Replace('.', ','));
            double y = DataService.func(x);
            Console.WriteLine(y);
        }
    }
}
