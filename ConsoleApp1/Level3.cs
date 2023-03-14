using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level3
    {
        static void Main(String[] args)
        {
            ex5();
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

        static void ex4()
        {
            int price = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i=0; i<count; i++)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split();

                int n = int.Parse(ss[0]);
                int m = int.Parse(ss[1]);

                sum += n * m;
            }

            if (price == sum)
                Console.WriteLine("Yes");

            else
                Console.WriteLine("No");
        }

        static void ex5()
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a / 4; i++)
                Console.Write("long ");
            Console.WriteLine("int");
        }
    }
}
