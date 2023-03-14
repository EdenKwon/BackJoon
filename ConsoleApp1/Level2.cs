using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level2
    {
        static void Main(string[] args)
        {
            ex2();
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
    } 
}
