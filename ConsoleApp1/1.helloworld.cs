using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex11();
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
            double a = double.Parse(ss[0]);
            double b = double.Parse(ss[1]);
            Console.WriteLine(a/b);
        }

        static void ex6()
        {
            String s = Console.ReadLine();
            String[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", a + b, a - b, a * b, a / b, a % b);
        }

        static void ex7()
        {
            String s = Console.ReadLine();
            Console.WriteLine(s + "??!");
        }

        static void ex8()
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            Console.WriteLine("{0}", a - 543);
        }

        static void ex9()
        {
            string s = Console.ReadLine();
            String[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            int c = int.Parse(ss[2]);

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", (a + b) % c, ((a % c) + (b + c)) % c, (a * b) % c, ((a % c) * (b % c)) % c);
        }

        static void ex10()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            int a = int.Parse(s1);
            int b = int.Parse(s2);

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", a * (b % 10), a * (b % 100 / 10), a * (b / 100), a * b);
        }

        static void ex11()
        {
            string s = Console.ReadLine();
            String[] ss = s.Split();

            long a = long.Parse(ss[0]);
            long b = long.Parse(ss[1]);
            long c = long.Parse(ss[2]);

            Console.WriteLine(a+b+c);
        }
    }
}