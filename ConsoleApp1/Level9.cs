using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
            ex4();
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


    }
}
