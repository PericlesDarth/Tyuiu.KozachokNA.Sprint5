using Sprint5.Lib;

namespace Tyuiu.KozachokNA.Sprint5.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string foo = MyIO.myInput("InPutDataFileTask7V9.txt");
            foo = DataService.DeleteUppers(foo);
            Console.WriteLine(foo);
            MyIO.myOutput("OutPutDataFileTask7V9.txt", foo);
        }
    }
}
