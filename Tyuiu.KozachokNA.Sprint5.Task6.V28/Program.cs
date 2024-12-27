using Sprint5.Lib;

namespace Tyuiu.KozachokNA.Sprint5.Task6.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string foo = MyIO.myInput("InPutDataFileTask6V28.txt");
            int count = DataService.CountFourDigits(foo);
            Console.WriteLine(count);
        }
    }
}
