using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level2
    {
        static void Main(string[] args)
        {
            ex5();
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
                case 10:
                    Console.WriteLine("A");
                    break;
                case 9:
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
    } 
}
