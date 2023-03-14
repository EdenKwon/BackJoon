using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level3
    {
        static void Main(String[] args)
        {
            ex1();
        }

        static void ex1()
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);

            for(int i= 1; i <= 9; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, a*i);
            }
        }
    }
}
