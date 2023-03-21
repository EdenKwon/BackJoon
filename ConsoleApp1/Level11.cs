using System;
using System.Collections.Generic;
using System.Data.Common;
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
            ex5();
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

            finally
            {
                if (eq1[0] == 0)
                {
                    x = (eq2[2] - eq2[1] * y) / eq2[0];
                }

                else
                    x = (eq1[2] - eq1[1] * y) / eq1[0];

                Print(x, y);
            }
            
        }

        static int check_Least(char[,] arr, int row, int column)
        {
            char[] ar = new char[64];
            int count = 0;
            int k = 0;
            for (int i = row; i < row + 8; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = column + 7; j >= column; j--)
                    {
                        ar[k] = arr[i, j];
                        k++;
                    }
                }

                else if (i % 2 == 0)
                {
                    for (int j = column; j < column + 8; j++)
                    {
                        ar[k] = arr[i, j];
                        k++;
                    }
                }
            }

            if (ar[0] == ar[1])
            {
                if (ar[0] == 'B') ar[1] = 'W';
                else ar[1] = 'B';
                count++;
            }

            for (int n=0; n<64; n++) 
            {
                
                
                if (n % 2 == 0)
                {
                    if (ar[0] != ar[n]) count++;
                }

                else
                {
                    if (ar[1] != ar[n]) count++;
                }
            }
            return count;
        }

        static int rePaint(char[,] arr, int row, int column)
        {
            int count = 64;
            for(int k=0; k<=row-8; k++)
            {
                for(int i=0; i<=column-8; i++)
                {
                    if (check_Least(arr, k, i) < count)
                        count = check_Least(arr, k, i);
                }       
            }
            return count;
        }

        static void ex4()
        {
            string s = Read();
            int[] size = s.Split().Select(x => ToInt(x)).ToArray();
            char[,] arr = new char[size[0], size[1]];

            for(int i=0; i < size[0]; i++)
            {
                string ss = Read();
                for (int j = 0; j < size[1]; j++)
                    arr[i, j] = ss[j];
            }

            Print(rePaint(arr, size[0], size[1]));
        }

        static void ex5()
        {
            string s = Read();
            int num = ToInt(s);

            int number = 666;
            int count = 0;
            string target = "666";
            while(count < num)
            {
                string nNum = number.ToString();
                for(int i=0; i<nNum.Length-2; i++)
                {
                    if (nNum.Substring(i, 3) == target)
                    {
                        count++; break;
                    }
                }
                number++;
            }

            Print(number-1);
        }
    }
}
