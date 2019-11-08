using System;

//例5 二维数组
//使用二维数组，完成一个3*4的矩阵的加法；
//2个矩阵分别是
//1 2 3 4
//5 6 7 8
//9 10 11 12
//和
//1 4 7 11
//2 5 8 12
//3 6 9 13

namespace CSHARPEX05
{
    class Program
    {
        static void Main(string[] args)
        {
            const int M = 3;
            const int N = 4;
            int[,] a = new int[M, N] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[,] b = new int[,] { { 1, 4, 7, 11 }, { 2, 5, 8, 12 }, { 3, 6, 9, 13 } };
            int[,] c = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,4}", c[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}