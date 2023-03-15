using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level4
    {

        static int ParseToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }

        static void Main()
        {
            ex1();
        }

        static void ex1()
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);

            string num = Console.ReadLine();
            string[] ss = num.Split(" ");
            string t = Console.ReadLine();

            int result = Array.FindAll(ss, x => x == t).Length;
            Print(result);
        }
        
    }
}