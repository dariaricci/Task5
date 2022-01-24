using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[20];
            int count = 0;
            Random p = new Random();
            for (int i = 0; i < 20; i++)
            {
                t[i] = p.Next(-50, 50);
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i += 2)
            {
                if ((t[i] % 2 != 0) && (t[i] > 0))
                {
                    count++;
                    Console.Write("{0} ",t[i]);
                }
            }
            Console.WriteLine();
            if (count > 0)
                Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах= {0}", count);
            else
                Console.WriteLine("Нечетные положительных элементов, стоящие на четных местах отсутствуют");
            Console.ReadKey();
        }
    }
}
