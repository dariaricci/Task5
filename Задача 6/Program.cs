using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int sumStroka = 0;
            int sumStrokaCount = 0;
            int sumStolbec = 0;
            int sumStolbecCount = 0;
            int sumDiag = 0;
            int sumDiag2 = 0;
            int[,] t = new int[N, N];


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int j = 0; j < N; j++)
            {
                sumStroka += t[0, j];
            }

            for (int i = 0; i < N; i++)
            {
                sumStolbec += t[i, 0];
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sumStrokaCount += t[i, j];
                }
                if (sumStrokaCount != sumStroka)
                    break;
                else sumStrokaCount = 0;
            }

            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    sumStolbecCount += t[i, j];
                }
                if (sumStolbecCount != sumStolbec)
                    break;
                else sumStolbecCount = 0;
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                        sumDiag += t[i, j];
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == (N - j - 1))
                        sumDiag2 += t[i, j];
                }
            }

            if ((sumStroka == sumStolbec) && (sumDiag == sumDiag2) && (sumStroka == sumDiag) && (sumStrokaCount == 0) && (sumStolbecCount == 0)&&(sumStroka>0))
                Console.WriteLine("Число является магическим квадратом");
            else
                Console.WriteLine("Число не является магическим квадратом");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
