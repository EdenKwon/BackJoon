namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex5();
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

        static void ex3()
        {
            String s = Console.ReadLine();
            String[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            Console.WriteLine(a - b);
        }

        static void ex4()
        {
            String s = Console.ReadLine();
            String[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            Console.WriteLine(a * b);
        }

        static void ex5()
        {
            String s = Console.ReadLine();
            String[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", a+b, a-b, a*b, a/b, a%b);
        }
    }
}