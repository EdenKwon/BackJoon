using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace BackJoon
{
    internal class Level12
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

        static void insertion_sort(int[] elem)
        {
            for (int i = 1; i < elem.Length; i++)
            {
                int key = elem[i];
                int j = i - 1;
                while (j >= 0 && key < elem[j])
                {
                    (elem[j], elem[j + 1]) = (elem[j + 1], elem[j]);
                    j--;
                }
                elem[j + 1] = key;
            }
        }

        static void ex1()
        {
            string s = Read();
            int num = ToInt(s);
            int[] elem = new int[num];

            for(int i = 0; i < num; i++)
            {
                string element = Read();
                elem[i] = ToInt(element);
            }

            insertion_sort(elem);
            //Array.Sort(elem);
            elem.ToList().ForEach(x => Print(x));
        }

        private static int find_middle(int[] arr)
        {
            Array.Sort(arr);
            return arr[2];
        }

        private static int find_average(int[] arr)
        {
            int sum = Enumerable.Sum(arr) / arr.Length;
            return sum;
        }

        static void ex2()
        {
            int[] elem = new int[5];

            for (int i = 0; i < 5; i++)
            {
                string element = Read();
                elem[i] = ToInt(element);
            }

            Semaphore sem = new Semaphore(0, 1);

            Thread avgThread = new Thread(() => 
            {
                Print(find_average(elem));
                sem.Release(); 
            });

            Thread midThread = new Thread(() => 
            {
                 sem.WaitOne();
                 Print(find_middle(elem));
            });

            avgThread.Start();
            midThread.Start();

            avgThread.Join();
            midThread.Join();
        }

        static void ex3()
        {
            string s = Read();
            int[] init = s.Split().Select(x => ToInt(x)).ToArray();
            int num = init[0];
            int cut = init[1];
            int[] score = new int[num];

            string ss = Read();
            score = ss.Split().Select(x => ToInt(x)).ToArray();

            Array.Sort(score);
            Array.Reverse(score);
            Print(score[cut-1]);
        }
    }
}
