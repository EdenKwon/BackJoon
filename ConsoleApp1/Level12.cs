using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ex1();
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
    }
}
