using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackJoon
{
    internal class Level3
    {
        static void lvl3Main(String[] args)
        {
            ex12();
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

        static void ex2_1()
        {
            Func<int, int, int> TwoAdd = (x, y) => x + y;
            static int ReadAndParse() => int.Parse(Console.ReadLine());
            static int ParseToInt(String s) => int.Parse(s);

            int a = ReadAndParse();
            int[] arr = new int[a];
            int index = 0;

            foreach (int elem in arr)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split();

                int n = ParseToInt(ss[0]);
                int m = ParseToInt(ss[1]);

                arr[index] = TwoAdd(n, m);
                index++;
            }

            arr.ToList().ForEach(x => Console.WriteLine(x));

            foreach (int i in arr)
            {
                Console.WriteLine(i);
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

        static void ex6()
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < a; i++)
            {
                using (StringReader reader = new StringReader(Console.ReadLine()))
                {
                    string[] text = reader.ReadLine().Split(' ');
                    int b = int.Parse(text[0]);
                    int c = int.Parse(text[1]);
                    builder.Append((b + c) + "\n");
                }
            }
            Console.WriteLine(builder);
        }

        static void ex7()
        {
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];

            for (int i = 0; i < a; i++)
            {
                string s = Console.ReadLine();
                string[] ss = s.Split();

                int n = int.Parse(ss[0]);
                int m = int.Parse(ss[1]);

                arr[i] = n + m;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Case #{0}: ", i+1);
                Console.WriteLine(arr[i]);
            }
        }
        
        static void ex8()
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            for (int i = 1; i <= a; i++)
            {
                using (StringReader reader = new StringReader(Console.ReadLine()))
                {
                    string[] text = reader.ReadLine().Split(' ');
                    int b = int.Parse(text[0]);
                    int c = int.Parse(text[1]);
                    builder.Append("Case #"+ i + ": " + b + " + " + c + " = " + (b + c) + "\n");
                }
            }
            Console.WriteLine(builder);
        }
        
        static void ex9()
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for(int j = 0; j< i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }     
        }

        static void ex10()
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = a - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void ex11()
        {
            StringBuilder builder = new StringBuilder();
            while(true)
            {
                using (StringReader reader = new StringReader(Console.ReadLine()))
                {
                    string[] text = reader.ReadLine().Split(' ');
                    int b = int.Parse(text[0]);
                    int c = int.Parse(text[1]);
                    if (b == 0 && c == 0)
                        break;

                    builder.Append((b + c) + "\n");
                }
            }
            Console.WriteLine(builder);
        }
        
        static void ex12()
        {
            StringBuilder builder = new StringBuilder();
            while (true)
            {
                using (StringReader reader = new StringReader(Console.ReadLine()))
                {
                    string s = reader.ReadLine();
                    if (s == null)
                        break;

                    string[] text = s.Split(' ');
                    int b = int.Parse(text[0]);
                    int c = int.Parse(text[1]);

                    builder.Append((b + c) + "\n");
                }
            }
            Console.WriteLine(builder);
        }
        
    }
}
