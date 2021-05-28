using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picture_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание:
            //1.3:
            //ххххх
            //0ххх0
            //00х00
            //0ххх0
            //ххххx
            //P.S : не получилось
            int[,] doubleArray = new int[5, 5];
            char[,] doubleArrayX = new char[5, 5];
            for (int i = 0; i < doubleArrayX.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArrayX.GetLength(1); j++)
                {
                    if (j>=0 || i>=0 )
                    {
                        doubleArrayX[i, j] = 'X';
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
