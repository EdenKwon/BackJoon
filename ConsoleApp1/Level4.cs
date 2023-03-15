using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level4
    {

        static int ParseToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }
        private static string Read() => Console.ReadLine(); 

        static void Main()
        {
            ex2();
        }

        static void ex1()
        {
            string s = Read();
            int a = int.Parse(s);

            string num = Read();
            string[] ss = num.Split(" ");
            string t = Read();

            int result = Array.FindAll(ss, x => x == t).Length;
            Print(result);
        }

        static void ex2()
        {
            string s = Read();
            string[] ss = s.Split();
            
            int a = ParseToInt(ss[0]);
            string[] ss1 = new string[a];

            int b = ParseToInt(ss[1]);

            string s1 = Read();
            string[] strArray = s1.Split();
            int[] intArray = strArray.Select(x =>  int.Parse(x)).ToArray();
            int[] resultArray = intArray.Where(x => x < b).ToArray();

            resultArray.ToList().ForEach(x => Console.Write(x + " "));
        }

        static void ex2_1()
        {
            string s = Read();
            int[] initCondition = s.Split().Select(x => int.Parse(x)).ToArray();

            int a = initCondition[0];
            int b = initCondition[1];

            //string[] ss1 = new string[a];

            string s1 = Read();
            int[] intArray = s1.Split().Select(x => int.Parse(x)).ToArray(); ;
            int[] resultArray = intArray.Where(x => x < b).ToArray();

            resultArray.ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}