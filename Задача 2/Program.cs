using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[15];
            Random p = new Random();
            for (int i = 0; i < 15; i++)
            {
                t[i] = p.Next(0, 50);
                Console.Write("{0} ", t[i]);
            }
            int Max = t[0];
            int Min = t[0];
            for (int i = 1; i < 15; i++)
            {
                if (t[i] > Max)
                {
                    Max = t[i];
                }
                else
                        if (t[i] < Min)
                {
                    Min = t[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine(Max);
            Console.WriteLine(Min);
            Console.ReadKey();
        }
    }
}
