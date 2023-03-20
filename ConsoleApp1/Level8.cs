using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Level8
    {
        static int ToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }
        static void Print(int num1, int num2) { Console.WriteLine("{0} {1}", num1, num2); }
        static void Print(string s) { Console.WriteLine(s); }
        private static string Read() => Console.ReadLine();

        static void lvl8Main(String[] args)
        {
            ex6();
        }

        static string Distinguish(int a, int b)
        {
            if (b % a == 0)
                return "factor";
            else if (a % b == 0)
                return "multiple";
            else
                return "neither";
        }

        static void ex1()
        {
            StringBuilder sb = new();
            while (true)
            {
                string s = Read();
                int[] num = s.Split().Select(x => ToInt(x)).ToArray();

                int num1 = num[0];
                int num2 = num[1];
                if (num1 == 0 && num2 == 0)
                {
                    Print(sb.ToString());
                    break;
                }

                string result = Distinguish(num1, num2);
                sb.Append(result + "\n");
            }
        }

        static void ex2()
        {
            string s = Read();
            int[] init = s.Split().Select(x => ToInt(x)).ToArray();

            int num = init[0];
            int count = init[1];

            var divList = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    divList.Add(num / i);
            }
            divList.Sort();

            if (divList.Count < count)
            {
                Print(0);
            }

            else
                Print(divList[count - 1]);
        }

        static void ex3()
        {
            StringBuilder sb = new();

            while (true)
            {
                string s = Read();
                int num = ToInt(s);

                if (num == -1)
                {
                    Print(sb.ToString());
                    break;
                }

                var divList = new List<int>();
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        divList.Add(num / i);
                }
                divList.Sort();

                int sum = 0;
                foreach (int elem in divList)
                {
                    sum += elem;
                }

                if (sum - num == num) //chatGPT
                {
                    sb.Append(num + " = " + string.Join(" + ", Enumerable.Range(1, num - 1).Where(i => num % i == 0)) + "\n");
                }

                else
                {
                    sb.Append(num + " is NOT perfect.\n");
                }
            }
        }

        static void ex4()
        {
            string s = Read();
            int num = ToInt(s);

            string numbers = Read();
            int[] init = numbers.Split().Select(x => ToInt(x)).ToArray();

            int count = init.Length;
            foreach (int elem in init)
            {
                if (elem <= 1)
                {
                    count--; continue;
                }

                for (int i = 2; i * i <= elem; i++)
                {
                    if (elem % i == 0)
                    {
                        count--; break;
                    }
                }
            }

            Print(count);
        }

        static bool isPrime(int x)
        {
            if (x == 1) return false;

            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void ex5()
        {
            string s = Read();
            int lowNum = ToInt(s);

            string s1 = Read();
            int highNum = ToInt(s1);

            int sum = 0;
            int minNum = 10000;
            for (int i = highNum; i >= lowNum; i--)
            {
                if (isPrime(i))
                {
                    sum += i;
                    if (minNum > i)
                        minNum = i;
                }
            }

            if (sum == 0)
            {
                Print(-1);
            }
            else
                Console.WriteLine("{0}\n{1}", sum, minNum);
        }

        static void ex6()
        {
            string s = Read();
            int num = ToInt(s);

            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    num = num / i;
                    Print(i);
                }
            }
        }

        static void ex7()
        {
            string s = Read();
            int init = ToInt(s);

            StringBuilder sb = new();
            int count = 0;
            while (count < init)
            {
                string number = Read();
                int num = ToInt(number);

                for (int i = num / 2; i >= 2; i--)
                {
                    if (isPrime(i) && isPrime(num - i))
                    {
                        sb.Append(i + " " + (num - i) + "\n"); break;
                    }
                }
                count++;
            }
            Print(sb.ToString());
        }
    }
}
