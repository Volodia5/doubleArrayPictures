using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picture_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание:
            //1.2:
            //00x00
            //00х00
            //xxххx
            //00x00
            //00x00
            int[,] doubleArray = new int[5, 5];
            char[,] doubleArrayX = new char[5, 5];
            for (int i = 0; i < doubleArrayX.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArrayX.GetLength(1); j++)
                {
                    if (i == 2 || j == 2)
                    {
                        doubleArrayX[i,j] = 'X';
                    }
                    else
                    {
                        doubleArrayX[i, j] = '0';
                    }
                    Console.Write($"{doubleArrayX[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
