using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level9
    {
        static int ToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }
        static void Print(int num1, int num2) { Console.WriteLine("{0} {1}", num1, num2); }
        static void Print(string s) { Console.WriteLine(s); }
        private static string Read() => Console.ReadLine();

        static void Main(String[] args)
        {
            ex2();
        }

        static int getMinLen(int a, int b) // a<=b
        {
            if ((double)b / 2 <= a)
                return b - a;
            else return a;
        }

        static int compareMin(int a, int b)
        {
            if (a > b) return b;
            else return a;
        }

        static void ex1()
        {
            string s = Read();
            int a = ToInt(s);

            string ss = Read();
            int b = ToInt(ss);

            Print(a * b);
        }

        static void ex2()
        {
            string s = Read();
            int[] init = s.Split().Select(x => ToInt(x)).ToArray();
            int x = init[0];
            int y = init[1];
            int w = init[2];
            int h = init[3];

            Print(compareMin(getMinLen(x, w), getMinLen(y, h)));
        }
    }
}
