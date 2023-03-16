using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level5
    {
        static int ParseToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }
        static void Print(int num1, int num2) { Console.WriteLine("{0}\n{1}", num1, num2); }
        static void Print(string s) { Console.WriteLine(s); }
        private static string Read() => Console.ReadLine();

        static void Main()
        {
            ex1();
        }

        static void ex1()
        {
            string s = Read();
            string num = Read();

            int num1 = ParseToInt(num)-1;
            Print(s[num1].ToString());
        }
    }
}
