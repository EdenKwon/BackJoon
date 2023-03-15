using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level4
    {

        static int ParseToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }
        static void Print(int num1, int num2) { Console.WriteLine("{0}\n{1}", num1, num2); }
        private static string Read() => Console.ReadLine(); 

        static void Main()
        {
            ex6();
        }

        static void ex1()
        {
            string s = Read();
            int a = int.Parse(s);

            string num = Read();
            string[] ss = num.Split(" ");
            string t = Read();

            int result = Array.FindAll(ss, x => x == t).Length;
            Print(result);
        }

        static void ex2()
        {
            string s = Read();
            string[] ss = s.Split();
            
            int a = ParseToInt(ss[0]);
            string[] ss1 = new string[a];

            int b = ParseToInt(ss[1]);

            string s1 = Read();
            string[] strArray = s1.Split();
            int[] intArray = strArray.Select(x =>  int.Parse(x)).ToArray();
            int[] resultArray = intArray.Where(x => x < b).ToArray();

            resultArray.ToList().ForEach(x => Console.Write(x + " "));
        }

        static void ex2_1()
        {
            string s = Read();
            int[] initCondition = s.Split().Select(x => int.Parse(x)).ToArray();

            int a = initCondition[0];
            int b = initCondition[1];

            //string[] ss1 = new string[a];

            string s1 = Read();
            int[] intArray = s1.Split().Select(x => int.Parse(x)).ToArray(); ;
            int[] resultArray = intArray.Where(x => x < b).ToArray();

            resultArray.ToList().ForEach(x => Console.Write(x + " "));
        }

        static void ex3()
        {
            string s = Read();
            int a = ParseToInt(s);

            string s1 = Read();
            int[] intArray = s1.Split().Select(x => int.Parse(x)).ToArray();

            int max = intArray.Max();
            int min = intArray.Min();

            Print(min, max);
        }

        static void ex4()
        {
            int[] arr = new int[9];
            int index = 0;
            while(index < arr.Length)
            {
                string s = Read();
                int ins = ParseToInt(s);
                arr[index++] = ins;
            }

            int max = arr.Max();
            int count = Array.IndexOf(arr, max) + 1;

            Print(max, count);
        }

        static void ex5()
        {
            string init = Read();
            int[] initCondition = init.Split().Select(x => int.Parse(x)).ToArray();

            int a = initCondition[0];
            int b = initCondition[1];

            //int[] input = new int[3];
            int[] box = new int[a];
            int index = 0;
            while (index < b)
            {
                string s = Read();
                int[] input = s.Split().Select(x => int.Parse(x)).ToArray();
                int n = input[0];
                int m = input[1];
                int num = input[2];


            }
        }

        static void ex6()
        {
            string init = Read();
            int[] initCondition = init.Split().Select(x => int.Parse(x)).ToArray();

            int a = initCondition[0];
            int b = initCondition[1];

            int[] box = new int[a];
            int BoxIndex = 0;

            while (BoxIndex < a)
            {
                box[BoxIndex] = BoxIndex + 1;
                BoxIndex++;
            }

            int index = 0;
            while (index < b)
            {
                string s = Read();
                int[] input = s.Split().Select(x => int.Parse(x)).ToArray();
                int n = input[0];
                int m = input[1];
                int temp;

                temp = box[n - 1];
                box[n - 1] = box[m - 1];
                box[m-1] = temp;
                index++;
            }
                
            box.ToList().ForEach(x => Console.Write(x + " "));
            
        }
    }
}