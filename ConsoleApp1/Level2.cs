using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace BackJoon
{
    internal class Level2
    {
        static void Main(string[] args)
        {
            ex7();
        }

        static void ex1()
        {
            String s = Console.ReadLine();
            String[] ss = s.Split();

            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);

            if (a > b)
            {
                Console.WriteLine(">");
            }

            else if (a < b)
            {
                Console.WriteLine("<");
            }

            else
            {
                Console.WriteLine("==");
            }
        }

        static void ex2()
        {
            String s = Console.ReadLine();
            int a = int.Parse(s);

            switch(a/10)
            {
                case 10 or 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
        }

        static void ex3()
        {
            String s = Console.ReadLine();
            int a = int.Parse(s);

            if ( a%4 == 0 && a%100 != 0)
            {
                Console.WriteLine("1");
            }

            else if (a%4 == 0 && a%400 == 0)
            {
                Console.WriteLine("1");
            }

            else
            {
                Console.WriteLine("0");
            }
        }

        static void ex4()
        {
            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();

            int a = int.Parse(s1);
            int b = int.Parse(s2);

            if ( a>0 && b>0)
                Console.WriteLine("1");

            else if (a<0 && b>0)
                Console.WriteLine("2");

            else if (a<0 && b<0)
                Console.WriteLine("3");

            else 
                Console.WriteLine("4");
        }

        static void ex5()
        {
            String s = Console.ReadLine();
            String[] ss = s.Split();

            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);

            if (b < 45)
            {
                if (a == 0)
                    a = a + 23;
                else
                    a = a - 1;
                b = 60 - (45 - b);
            }

            else
                b = b - 45;

            Console.WriteLine("{0} {1}", a, b);
        }

        static void ex6()
        {
            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();
            String[] ss = s1.Split();

            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            int c = int.Parse(s2);

            if (b + c >= 60)
            {
                a += (b + c) / 60;
                b = (b + c) % 60;

                if (a >= 24)
                    a = a - 24;
            }

            else
                b += c;

            Console.WriteLine("{0} {1}", a, b);
        }

        public static int max(int a, int b, int c)
        {
            int[] x = { a, b, c };
            int max = 0;
            int xLen = x.Length;
            for(int i=0; i<xLen; i++)
                if(max < x[i])
                    max = x[i];

            return max;
        }

        static void ex7()
        {
            String s = Console.ReadLine();
            String[] ss = s.Split();

            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            int c = int.Parse(ss[2]);

            if (a.Equals(b) && a.Equals(c))
            {
                Console.WriteLine(10000 + a * 1000);
            }

            else if (a.Equals(b) || a.Equals(c) || b.Equals(c))
            {
                if (a.Equals(b))
                    Console.WriteLine(1000 + a * 100);

                else
                    Console.WriteLine(1000 + c * 100);
            }

            else
                Console.WriteLine(100 * max(a, b, c));
        }
    } 
}
