using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Level6
    {
        static int ParseToInt(string s) => int.Parse(s);
        static void Print(int num) { Console.WriteLine(num); }
        static void Print(int num1, int num2) { Console.WriteLine("{0}\n{1}", num1, num2); }
        static void Print(string s) { Console.WriteLine(s); }
        private static string Read() => Console.ReadLine();

        static void Main(String[] args)
        {
            ex2();
        }

        static void ex1()
        {
            Console.WriteLine(@"         ,r'""7
r`-_   ,'  ,/
 \. "". L_r'
   `~\/
      |
      |
");

        }

        static void ex2()
        {
            string s = Read();
            int[] ss = s.Split().Select(x=> ParseToInt(x)).ToArray();

            int[] whitePiece = new int[6];
            int index = 0;
            while(index < 6)
            {
                if(index < 2)
                    whitePiece[index] = 1 - ss[index];
                else if(index < 5)
                    whitePiece[index] = 2 - ss[index];
                else 
                    whitePiece[index] = 8 - ss[index];

                index++;
            }
            whitePiece.ToList().ForEach(x => Console.Write(x+ " "));
        }
    }
}
