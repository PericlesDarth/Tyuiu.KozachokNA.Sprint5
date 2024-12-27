namespace Sprint5.Lib
{
    public class MyIO
    {
        public static string myInput(string name)
        {
            string path = $@"C:\DataSprint5\" + name;

            string res = File.ReadAllText(path);
            return res;
        }
        public static void myOutput(string name, string foo)
        {
            string path = $@"C:\DataSprint5\" + name;
            File.Create(path).Close();

            File.WriteAllText(path, foo);
        }
        public static void multiLineOutput(string name, string[] foo)
        {
            string path = $@"C:\DataSprint5\" + name;
            File.Create(path).Close();

            File.WriteAllLines(path, foo);
        }
    }
}
