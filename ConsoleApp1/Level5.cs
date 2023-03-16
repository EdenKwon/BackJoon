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

        static void Main(String[] args)
        {
            ex3();
        }

        static void ex1()
        {
            string s = Read();
            string num = Read();

            int num1 = ParseToInt(num);
            Print(s[num1].ToString());
        }

        static void ex2()
        {
            string s = Read();
            int len = s.Length;

            Print(len);
        }

        static void ex3()
        {
            string s = Read();
            int testCase = ParseToInt(s);
            int index = 0;

            StringBuilder builder = new StringBuilder();
            while (index <  testCase)
            {
                using (StringReader reader = new StringReader(Console.ReadLine()))
                {
                    string text = reader.ReadLine();
                    string firstStr = text.Substring(0,1);
                    string lastStr = text.Substring(text.Length-1, 1);

                    builder.Append(firstStr + lastStr+ "\n");
                }
                index++;
            }
            Console.WriteLine(builder);
        }

    }
}
