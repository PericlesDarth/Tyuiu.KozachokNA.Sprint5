using Sprint5.Lib;

namespace Tyuiu.KozachokNA.Sprint5.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string foo = MyIO.myInput("InPutDataFileTask5V12.txt");
            double x, y;
            string xx, yy;
            (x, y) = DataService.Summation(foo);
            xx = Convert.ToString(x);
            yy = Convert.ToString(y);
            Console.WriteLine("Первое значение - алгебраическая разница между суммами положительных и отрицательных значений;");
            Console.WriteLine("Второе значение - разница по модулю.");
            Console.WriteLine(xx + "; " + yy);
        }
    }
}
