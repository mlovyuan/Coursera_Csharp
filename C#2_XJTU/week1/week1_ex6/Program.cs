using System;

//例6 利用交错数组生成如下杨辉三角（又称Pascal三角）。
// 1
// 1 1
// 1 2 1
// 1 3 3 1
// 1 4 6 4 1
// 1 5 10 10 5 1
// 1 6 15 20 15 6 1
// 1 7 21 35 35 21 7 1
// 1 8 28 56 70 56 28 8 1
// 1 9 36 84 126 126 84 36 9 1

namespace CSHARPEX06
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            int[][] pascal = new int[N][];
            for (int i = 0; i < N; i++)
            {
                pascal[i] = new int[i + 1];
            }
            pascal[0][0] = 1;

            for (int i = 1; i < N; i++)
            {
                pascal[i][0] = 1;
                pascal[i][i] = 1;
                for (int j = 1; j < i; j++)
                {
                    pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0,4}", pascal[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}