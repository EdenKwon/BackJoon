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
            ex1();
        }

        static void ex1()
        {
            Console.WriteLine(@"
         ,r'""7
r`-_   ,'  ,/
 \. "". L_r'
   `~\/
      |
      |
"       );

        }
    }
}
