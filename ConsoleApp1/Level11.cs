using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level11
    {
        static int ToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }
        static void Print(int num1, int num2) { Console.WriteLine("{0} {1}", num1, num2); }
        static void Print(long num) { Console.WriteLine(num); }
        static void Print(double num) { Console.WriteLine(num); }
        static void Print(string s) { Console.WriteLine(s); }
        private static string Read() => Console.ReadLine();

        static void Main(String[] args)
        {
            ex3();
        }

        static int Find_Max(int[] card, int sum)
        {
            int max = 0;
            for(int i=0; i<card.Length; i++)
            {
                for(int j=i+1; j<card.Length; j++)
                {
                    for(int k=j+1; k<card.Length; k++)
                    {
                        if ( max < card[i] + card[j] + card[k] &&
                            card[i] + card[j] + card[k] <= sum )
                        {
                            max = card[i] + card[j] + card[k];
                        }
                    }
                }
            }
            return max;
        } 

        static int Find_Max_GPT(int[] card, int sum) //chatGPT
        {
            int max = 0;
            for (int i = card.Length - 1; i >= 2; i--)
            {
                int j = 0;
                int k = i - 1;

                while (j < k)
                {
                    int currentSum = card[i] + card[j] + card[k];

                    if (currentSum == sum)
                    {
                        return currentSum; 
                    }
                    else if (currentSum < sum)
                    {
                        max = Math.Max(max, currentSum);
                        j++; 
                    }
                    else
                    {
                        k--; 
                    }
                }
            }

            return max; 
        }

        static void Find_Small(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int sum = i;
                int num = i;

                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                if (sum == n)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("0");
        }


        static void ex1()
        {
            string s = Read();
            int[] init = s.Split().Select(x => ToInt(x)).ToArray();

            int num = init[0];
            int sum = init[1];

            string ss = Read();
            int[] card = ss.Split().Select(x =>ToInt(x)).ToArray();

            Print(Find_Max(card, sum));
        }

        static void ex2()
        {
            string s = Read();
            int num = ToInt(s);

            Find_Small(num);
        }

        static void ex3()
        {
            string s = Read();
            int[] num = s.Split().Select(x => ToInt(x)).ToArray();

            int[] eq1 = new int[3];
            int[] eq2 = new int[3];

            Array.Copy(num, 0, eq1, 0, 3);
            Array.Copy(num, 3, eq2, 0, 3);
            int x = 0;
            int y = 0;
            try
            {
                int div = eq1[1] * eq2[0] - eq1[0] * eq2[1];
                if (div == 0)
                {
                    throw new DivideByZeroException();
                }
                y = (eq1[2] * eq2[0] - eq1[0] * eq2[2]) / div;
            }
            
            catch (DivideByZeroException)
            {
                y = 0;
            }

            if (eq1[0] == 0)
            {
                x = (eq2[2] - eq2[1] * y) / eq2[0];
            }

            else 
                x = (eq1[2] - eq1[1] * y) / eq1[0];

            Print(x, y);
        }
    }
}
