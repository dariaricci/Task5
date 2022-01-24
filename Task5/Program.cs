using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t= new int[7];
            float s = 0;
            for (int i = 0; i < 7; i++)
            {
               t[i]=Convert.ToInt32(Console.ReadLine());
                s += t[i];
            }
            Console.WriteLine("{0:f2}",s/7);
            Console.ReadKey();

        }
    }
}
