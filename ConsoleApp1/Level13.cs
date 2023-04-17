using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level13
    {
        static int ToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }
        static void Print(int num1, int num2) { Console.WriteLine("{0} {1}", num1, num2); }
        static void Print(string s1, string s2) { Console.WriteLine("{0} {1}", s1, s2); }
        static void Print(int s1, string s2) { Console.WriteLine("{0} {1}", s1, s2); }
        static void Print(long num) { Console.WriteLine(num); }
        static void Print(double num) { Console.WriteLine(num); }
        static void Print(string s) { Console.WriteLine(s); }
        private static string Read() => Console.ReadLine();

        static void lvl13Main(String[] args)
        {
            ex2();
        }

        static void ex1()
        {
            string s = Read();
            int num = ToInt(s);

            for(int i=0; i < num; i++)
            {
                string n = Read();
                int[] nums = s.Split().Select(x=> ToInt(x)).ToArray();

            }
        }

        static void ex2()
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int lcm = GetLCM(num1, num2);
            Console.WriteLine($"The LCM of {num1} and {num2} is {lcm}.");
        }

        static int GetLCM(int num1, int num2)
        {
            int maxNum = Math.Max(num1, num2);
            int minNum = Math.Min(num1, num2);
            int lcm = maxNum;

            while (lcm % minNum != 0)
            {
                lcm += maxNum;
            }

            return lcm;
        }
    }
}
