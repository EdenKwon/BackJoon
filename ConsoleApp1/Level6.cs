using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        static void Print(char cha) { Console.WriteLine(cha); }
        private static string Read() => Console.ReadLine();

        static void Main(String[] args)
        {
            ex6();
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

        static void ex3()
        {
            string s = Read();
            int num = ParseToInt(s);
            //string[] prtStar = new string[2*num -1];
            //prtStar = Enumerable.Repeat(" ", 2*num -1).ToArray();
            //int count = 0;
            StringBuilder sb = new StringBuilder();
            for(int i=1; i<=num; i++)
            {
                sb.Append(' ', num - i);
                sb.Append('*', i * 2 - 1);
                sb.AppendLine();
            }

            for(int j=num-1; j>=1; j--)
            {
                sb.Append(' ', num - j);
                sb.Append('*', j * 2 - 1);
                sb.AppendLine();
            }

            Print(sb.ToString());
        }

        static void ex4()
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
                int bb = input[0];
                int eb = input[1];
                int mb = input[2];

                for (int i = mb; i <= eb; i++)
                {
                    box[i] = box[bb + i - 1];
                }

                for (int i = bb; i <= mb; i++)
                {
                    box[i] = box[mb + i];
                }

            }

            box.ToList().ForEach(x => Console.Write(x + " "));

        }

        static void ex5()
        {
            string s = Read();
            int len = s.Length;
            char[] ss = s.ToCharArray();

            bool isPal = true;

            for(int i=0; i<len/2; i++)
            {
                if (ss[i] != ss[len - i -1])
                {
                    isPal = false;
                    break;
                }
            }

            if(isPal)
            {
                Print(1);
            }

            else
            {
                Print(0);
            } 
        }

        static void ex6()
        {
            string s = Read();
            int[] index = new int[s.Length];    

            for(int i=0; i<s.Length; i++)
            {
                char c = s[i];
                index[i] = c;
                if (index[i] >=97)
                {
                    index[i] -= 32;
                }
            }

            //chatGPT
            var groups = index.GroupBy(n => n);
            var maxCount = groups.Max(g => g.Count());
            var mostCommonValues = groups.Where(g => g.Count() == maxCount).Select(g => g.Key);
    
            int count = mostCommonValues.Count();
            if (count > 1)
            {
                Print("?");
            }
            else
                Print((char)mostCommonValues.First());
        }  
    }
}
