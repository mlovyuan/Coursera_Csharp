using System;

//例10 输出（OUT 参数）
//使用一个方法，返回2个整数的和以及差。

namespace CSHARPEX10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int x2 = 5;
            int x3;
            int x4;
            AddM(x1, x2, out x3, out x4);
            Console.WriteLine("{0}, {1}", x3, x4);
        }
        static void AddM(int x1, int x2, out int x3, out int x4)
        {
            x3 = x1 + x2;
            x4 = x1 - x2;
        }
    }
}