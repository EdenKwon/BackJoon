using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection;
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
        static void Print(string s1, string s2) { Console.WriteLine("{0} {1}", s1, s2); }
        static void Print(int s1, string s2) { Console.WriteLine("{0} {1}", s1, s2); }
        static void Print(long num) { Console.WriteLine(num); }
        static void Print(double num) { Console.WriteLine(num); }
        static void Print(string s) { Console.WriteLine(s); }
        private static string Read() => Console.ReadLine();

        static void Main(String[] args)
        {
            ex11();
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

        static void insertion_sort(string[] elem)
        {
            for (int i = 1; i < elem.Length; i++)
            {
                string key = elem[i];
                int j = i - 1;
                while (j >= 0)
                {
                    if (elem[j].Length > key.Length || (elem[j].Length == key.Length && elem[j].CompareTo(key) > 0))
                    {
                        (elem[j + 1], elem[j]) = (elem[j], elem[j + 1]);
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
                elem[j + 1] = key;
            }
        }

        static int find_middle(int[] arr, int num)
        {
            Array.Sort(arr);
            return arr[num / 2];
        }

        static float find_average(int[] arr)
        {
            float sum = (float)Enumerable.Sum(arr) / arr.Length;
            if (sum == 0 && Math.Sign(sum) == -1)
            {
                sum = 0;
            }
            return sum;
        }

        static int find_mode(int[] arr) //chatGPT
        {
            var modes = arr.GroupBy(x => x)
                          .OrderByDescending(g => g.Count());
            int maxCount = modes.First().Count();
            int secondCount = modes.Skip(1).Count();

            if(maxCount == secondCount)
            {
                return modes.Skip(1).First().Key;
            }
            
            else
            {
                return modes.First().Key;
            }
        }

        static int find_range(int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length-1]- arr[0];
        }

        static void ex1()
        {
            string s = Read();
            int num = ToInt(s);
            int[] elem = new int[num];

            for (int i = 0; i < num; i++)
            {
                string element = Read();
                elem[i] = ToInt(element);
            }

            insertion_sort(elem);
            //Array.Sort(elem);
            elem.ToList().ForEach(x => Print(x));
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
                 Print(find_middle(elem, 5));
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
            Print(score[cut - 1]);
        }

        public static void MergeSort(int[] arr)
        {
            if (arr.Length < 2)
            {
                return;
            }

            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }

            for (int i = mid; i < arr.Length; i++)
            {
                right[i - mid] = arr[i];
            }

            MergeSort(left);
            MergeSort(right);

            Merge(arr, left, right);
        }

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                arr[k++] = left[i++];
            }

            while (j < right.Length)
            {
                arr[k++] = right[j++];
            }
        }

        static void ex4()
        {
            string s = Read();
            int num = ToInt(s);
            int[] elem = new int[num];

            for (int i = 0; i < num; i++)
            {
                string element = Read();
                elem[i] = ToInt(element);
            }

            MergeSort(elem);
            elem.ToList().ForEach(x => Print(x));
        }

        static void ex6()
        {
            string s = Read();
            int num = ToInt(s);
            int[] elem = new int[num];

            for (int i = 0; i < num; i++)
            {
                string element = Read();
                elem[i] = ToInt(element);
            }

            Semaphore sem = new Semaphore(0, 1);
            Thread[] threads = new Thread[]
            {
                new Thread(() => {
                    Print(find_average(elem).ToString("F0"));
                    sem.Release();
                }),
                new Thread(() =>
                {
                    sem.WaitOne();
                    Print(find_middle(elem, num));
                    sem.Release();
                }),
                new Thread(() =>
                {
                    sem.WaitOne();
                    Print(find_mode(elem));
                    sem.Release();
                }),
                new Thread(() =>
                {
                    sem.WaitOne();
                    Print(find_range(elem));
                    sem.Release();
                })
            };

            foreach (Thread t in threads)
            {
                t.Start();
            }
            
            foreach (Thread t in threads)
            {
                t.Join();
            }
        }
        
        static void ex7()
        {
            string s = Read();
            int num = ToInt(s);
            int len = s.Length;
            int[] elem = new int[len];

            for (int i = len; i > 0; i--)
            {
                elem[len - i] = num / (int)Math.Pow(10, i - 1);
                num -= elem[len - i] * (int)Math.Pow(10, i - 1);
            }
            Array.Sort(elem);
            Array.Reverse(elem);
            elem.ToList().ForEach(x => Console.Write(x));
        }

        static void ex8()
        {
            string s = Read();
            int num = ToInt(s);
            List<Point> points = new List<Point>();
            
            for(int i=0; i<num; i++) 
            {
                string ss = Read();
                int[] loc = ss.Split().Select(x => ToInt(x)).ToArray();
                points.Add(new Point(loc[0], loc[1]));
            }

            
            List<Point> sortedPoints = points.OrderBy(p => p.X).ThenBy(p => p.Y).ToList();
            
            foreach (Point p in sortedPoints)
            {
                Print(p.X, p.Y);
            }
        }

        static void ex9()
        {
            string s = Read();
            int num = ToInt(s);
            List<Point> points = new List<Point>();

            for (int i = 0; i < num; i++)
            {
                string ss = Read();
                int[] loc = ss.Split().Select(x => ToInt(x)).ToArray();
                points.Add(new Point(loc[0], loc[1]));
            }


            List<Point> sortedPoints = points.OrderBy(p => p.Y).ThenBy(p => p.X).ToList();

            foreach (Point p in sortedPoints)
            {
                Print(p.X, p.Y);
            }
        }

        static void ex10()
        {
            string s = Read();
            int num = ToInt(s);
            string[] words = new string[num];

            for (int i=0; i< num; i++)
            {
                string ss = Read();
                words[i] = ss;
            }
            insertion_sort(words);
            words.Distinct().ToList().ForEach(x => Print(x));    
        }

        struct ageName
        {
            public int Age { get; set; }
            public string Name { get; set; }

            public ageName(int age, string name)
            {
                Age = age;
                Name = name;
            }
        }

        static void ex11()
        {
            string s = Read();
            int num = ToInt(s);
            List<ageName> an = new List<ageName>();

            for (int i=0; i<num; i++)
            {
                string ss = Read();
                string[] info = ss.Split().ToArray();
                int age = ToInt(info[0]);

                an.Add(new ageName(age, info[1]));
            }

            List<ageName> sortedAN = an.OrderBy(p => p.Age).ToList();
            foreach (ageName p in sortedAN)
            {
                Print(p.Age, p.Name);
            }
        }
    }
}
