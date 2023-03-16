using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
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
            ex10();
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
            int[] initCondition = s.Split(" ").Select(x => int.Parse(x)).ToArray();

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

            int[] box = new int[a];
    
            int index = 0;
            while (index < b)
            {
                string s = Read();
                int[] input = s.Split().Select(x => int.Parse(x)).ToArray();
                int fn = input[0]-1;
                int ln = input[1]-1;
                int num = input[2];

                for (int i = fn; i <= ln; i++)
                {
                    box[i] = num;
                }
                index++;
            }

            box.ToList().ForEach(x => Console.Write(x + " "));
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

        static void ex7()
        {
            int[] arr = new int[30];
            int index = 0;
            while (index < 28)
            {
                string s = Read();
                int ins = ParseToInt(s);
                arr[ins-1] = 1;
                index++;
            }
            int result1 = Array.IndexOf(arr, 0)+1;
            int result2 = Array.LastIndexOf(arr, 0)+1;
            Print(result1, result2);
        }

        static void ex8()
        {
            int[] arr = new int[10];
            int index = 0;
            while (index < 10)
            {
                string s = Read();
                //arr = s.Split().Select(x => int.Parse(x)%42).ToArray();
                int ins = ParseToInt(s);
                arr[index] = ins % 42;
                index++;
            }
            
            int count = arr.Distinct().Count();

            Print(count);
        }

        static void ex9()
        {
            string s = Read();
            int[] initCon = s.Split().Select(x => int.Parse(x)).ToArray();
            int a = initCon[0];
            int b = initCon[1];

            int[] box = new int[a];
            int BoxIndex = 0;

            while (BoxIndex < a)
            {
                box[BoxIndex] = BoxIndex + 1;
                BoxIndex++;
            }

            int count = 0;

            while (count < b)
            {
                string ss = Read();
                int[] rev = ss.Split().Select(x => int.Parse(x)).ToArray();

                int fInd = rev[0]-1;
                int length = rev[1]-rev[0]+1;

                Array.Reverse(box, fInd, length);
                count++;
            }
            box.ToList().ForEach(x => Console.Write(x + " "));
        }

        static void ex10()
        {
            string s = Read();
            int sub = int.Parse(s);

            string ss = Read();
            float[] score = new float[sub];
            score = ss.Split().Select(x => float.Parse(x)).ToArray();
            Array.Sort(score);

            float max = score.Max();
            for (int i=0; i<sub; i++)
            {
                score[i] = score[i] / max * 100;
            }

            float avg = score.Select(x => x).Aggregate((total, next) => total + next) / (float)sub;
            Console.WriteLine(avg.ToString("F6"));

        }
    }
}