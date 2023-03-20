using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level9
    {
        static int ToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }
        static void Print(int num1, int num2) { Console.WriteLine("{0} {1}", num1, num2); }
        static void Print(long num) { Console.WriteLine(num); }
        static void Print(double num) { Console.WriteLine(num); }
        static void Print(string s) { Console.WriteLine(s); }
        private static string Read() => Console.ReadLine();

        static int Max(int a, int b, int c)
        {
            if (a >= b && a >= c)
                return a;
            else if (a <= b && c <= b)
                return c;
            else
                return c;
        }

        static void Main(String[] args)
        {
            ex7();
        }

        static int getMinLen(int a, int b) // a<=b
        {
            if ((double)b / 2 <= a)
                return b - a;
            else return a;
        }

        static int compareMin(int a, int b)
        {
            if (a > b) return b;
            else return a;
        }

        struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        static Point findPoint(Point p1, Point p2, Point p3)
        {
            if (p1.X == p2.X)
            {
                return new Point(p3.X, (p3.Y == p2.Y) ? p1.Y : p2.Y);
            }

            else if (p1.X == p3.X)
            {
                return new Point(p2.X, (p2.Y == p1.Y) ? p3.Y : p1.Y);
            }

            else
            {
                return new Point(p1.X, (p1.Y == p2.Y) ? p3.Y : p2.Y);
            }
        }

        static void check_ToAngle(int a, int b, int c, Action<string> Callback)
        {
            string s = null;
            if (a == 60 && b == 60 && c == 60) s = "Equilateral";
            else if (a + b + c == 180 && a == b || a == c || b == c) s = "Isosceles";
            else if (a + b + c == 180 && a != b && a != c && b != c) s = "Scalene";
            else s = "Error";

            Callback(s);
        }

        static string check_ToLength(int a, int b, int c)
        {
            string s = null;
            if (a <= 0 || b <= 0 || c <= 0)
                s = "Invalid";
            else if ((a + b) <= c || (a + c) <= b || (b + c) <= a) 
                s = "Invalid";
            else if (a == b && b == c)
                s = "Equilateral";     
            else if (a == b || a == c || b == c)
                s = "Isosceles";
            else
                s = "Scalene";

            return s;
        }

        static void ex1()
        {
            string s = Read();
            int a = ToInt(s);

            string ss = Read();
            int b = ToInt(ss);

            Print(a * b);
        }

        static void ex2()
        {
            string s = Read();
            int[] init = s.Split().Select(x => ToInt(x)).ToArray();
            int x = init[0];
            int y = init[1];
            int w = init[2];
            int h = init[3];

            Print(compareMin(getMinLen(x, w), getMinLen(y, h)));
        }

        static Point ReadPoint()
        {
            string s = Read();
            int[] p = s.Split().Select(x => ToInt(x)).ToArray();
            return new Point(p[0], p[1]);
        }

        static void ex3()
        {
            var Point1 = ReadPoint();
            var Point2 = ReadPoint();
            var Point3 = ReadPoint();
            var Point4 = new Point();

            Point4 = findPoint(Point1, Point2, Point3);
            Print(Point4.X, Point4.Y);
        }

        static void ex4()
        {
            string s = Read();
            long num = ToInt(s);

            Print(num * 4);
        }

        static void ex5()
        {
            string s = Read();
            int num = ToInt(s);

            int[] x = new int[num];
            int[] y = new int[num];

            for (int i = 0; i < num; i++)
            {
                string point = Read();
                int[] p = point.Split().Select(x => ToInt(x)).ToArray();

                x[i] = p[0];
                y[i] = p[1];
            }

            int xLen = x.Max() - x.Min();
            int ylen = y.Max() - y.Min();
            Print(xLen * ylen);
        }

        static void ex6()
        {
            int[] angle = new int[3];
            for (int i = 0; i < 3; i++)
            {
                string s = Read();
                angle[i] = ToInt(s);
            }

            check_ToAngle(angle[0], angle[1], angle[2], Print);
        }

        static void ex7()
        {
            StringBuilder sb = new();
            while(true)
            {
                string s = Read();
                int[] len = s.Split().Select(x =>ToInt(x)).ToArray();
                if (len[0] == 0 && len[1] == 0 && len[2] == 0)
                {
                    Print(sb.ToString());
                    break;
                }

                sb.Append(check_ToLength(len[0], len[1], len[2]) + "\n");
            }
        }
    }
}
