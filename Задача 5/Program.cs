using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] t=new int[N,N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (((i % 2 == 0) && (j % 2 == 0))|| ((i % 2 != 0) && (j % 2 != 0)))
                    {
                        t[i, j] = 1;
                    }
                    else
                    {
                        t[i, j] = 0;
                    }
                    Console.Write("{0,4}",t[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
