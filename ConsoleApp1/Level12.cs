﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            ex9();
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

            MergeSort(points, 0, points.Count - 1);

            foreach (Point p in points)
            {
                Print(p.X, p.Y);
            }
        }

        static void MergeSort(List<Point> points, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(points, left, mid);
                MergeSort(points, mid + 1, right);
                Merge(points, left, mid, right);
            }
        }

        static void Merge(List<Point> points, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            List<Point> leftArr = new List<Point>();
            List<Point> rightArr = new List<Point>();

            for (int i = 0; i < n1; i++)
            {
                leftArr.Add(points[left + i]);
            }

            for (int j = 0; j < n2; j++)
            {
                rightArr.Add(points[mid + 1 + j]);
            }

            int x = 0;
            int y = 0;
            int k = left;

            while (x < n1 && y < n2)
            {
                if (leftArr[x].Y < rightArr[y].Y || (leftArr[x].Y == rightArr[y].Y && leftArr[x].X < rightArr[y].X))
                {
                    points[k] = leftArr[x];
                    x++;
                }
                else
                {
                    points[k] = rightArr[y];
                    y++;
                }
                k++;
            }

            while (x < n1)
            {
                points[k] = leftArr[x];
                x++;
                k++;
            }

            while (y < n2)
            {
                points[k] = rightArr[y];
                y++;
                k++;
            }
        }

    }
}
