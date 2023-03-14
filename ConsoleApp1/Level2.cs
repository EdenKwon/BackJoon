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
            ex1();
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
    } 
}
