using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[10];
            int N;
            Random p = new Random();
            for (int i = 0; i < 10; i++)
            {
                t[i] = p.Next(-50, 50);
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (t[j] < t[i])
                    {
                        N = t[j];
                        t[j] = t[i];
                        t[i] = N;
                    }
                }
            }
            for (int i = 5; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (t[j] > t[i])
                    {
                        N = t[j];
                        t[j] = t[i];
                        t[i] = N;
                    }
                }
                
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", t[i]);
            }
            Console.ReadKey();
        }
    }
}
