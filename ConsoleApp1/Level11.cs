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
            ex1();
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
    }
}
