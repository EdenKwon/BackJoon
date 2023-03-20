using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level10
    {
        static int ToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }
        static void Print(int num1, int num2) { Console.WriteLine("{0} {1}", num1, num2); }
        static void Print(long num) { Console.WriteLine(num); }
        static void Print(double num) { Console.WriteLine(num); }
        static void Print(string s) { Console.WriteLine(s); }
        private static string Read() => Console.ReadLine();

        static void Main(String[] args)
        {
            ex1();
        }

        static int MenOfPassion(int []A, int n)
        {
            int i = n / 2;
            return A[i];
        }

        static void ex1()
        {
            string s = Read();
            int n = ToInt(s);
            int[] A = new int[n];

            MenOfPassion(A, n);
            Print(1, 0);
        }
    }
}
