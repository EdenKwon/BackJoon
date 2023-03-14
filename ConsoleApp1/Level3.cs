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
            ex3();
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

        static void ex2()
        {
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];

            for(int i= 0; i<a; i++)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split();

                int n = int.Parse(ss[0]);
                int m = int.Parse(ss[1]);

                arr[i] = n + m;
            }

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void ex3()
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= a; i++)
                sum += i;

            Console.WriteLine(sum);
        }
    }
}
