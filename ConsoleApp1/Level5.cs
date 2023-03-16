using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
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
            ex9();
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

        static void ex4()
        {
            string s = Read();
            char sChar = s[0];
            int ascii = (int)sChar;
            Console.WriteLine(ascii);
        }

        static void ex5()
        {
            string s = Read();
            int n = ParseToInt(s);

            string num = Read();
            int sum = 0;

            for(int i=0; i<n; i++)
            {
                string ss = num.Substring(i, 1);
                int a = ParseToInt(ss);
                sum += a;
            }
            Print(sum);
        }

        static void ex6()
        {
            string str = Read();
            int len = str.Length;

            int[] arr = Enumerable.Repeat(-1, 26).ToArray(); //check
            
            for(int i=0; i<len; i++)
            {
                char c = str[i];
                int index = c - 'a';

                if(arr[index] == -1)
                {
                    arr[index] = i;
                }
            }

            foreach(int elem in arr) 
            {
                    Console.Write(elem + " ");
            }
        }

        static void ex7()
        {
            string s = Read();
            int num = ParseToInt(s);

            int index = 0;
            StringBuilder builder = new StringBuilder();
            while (index < num)
            {
                string ss = Read();
                string[] NumStr = ss.Split().ToArray();

                int count = ParseToInt(NumStr[0]);
                string[] str = NumStr[1].Split().ToArray();

                for(int i=0; i<str.Length; i++)
                {
                    builder.Append(str[i]);
                }
                builder.Append("\n");
                index++;
            }
            Print(builder.ToString());
        }

        static void ex8()
        {
            string s = Read();
            string[] sub = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //check
            Print(sub.Length);
        }

        static void ex9()
        {
            string s = Read();
            string[] str = s.Split().ToArray();
            int[] result = new int[2];

            int count = 0;
            while(count < 2)
            {
                string reversedString = new string(str[count].Reverse().ToArray());
                result[count] = ParseToInt(reversedString);
                count++;
            }

            if (result[0] > result[1])
                Print(result[0]);
            else
                Print(result[1]);
        }
    }
}
