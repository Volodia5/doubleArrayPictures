using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleArrayHomeworkPictures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание
            //    1.2:
            //    ххххх
            //    0хххх
            //    00ххх
            //    000хх
            //    0000х
            int[,] doubleArray = new int[5, 5];
            char[,] doubleArrayX = new char[5, 5];
            for (int i = 0; i < doubleArray.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArray.GetLength(1); j++)
                {
                    if (i <= j)
                    {
                    doubleArrayX[i,j] = 'X';
                    }
                    else
                    {
                        doubleArrayX[i, j] = '0';
                    }
                    Console.Write($"{doubleArrayX[i,j]} ");
                }
                Console.WriteLine();
            }
                Console.ReadKey();
        }
    }
}
