namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex2();
        }

        static void ex1()
        {
            Console.WriteLine("Hello World!");
        }

        static void ex2()
        {
            String s = Console.ReadLine();
            String[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            Console.WriteLine(a + b);
        }
    }
}