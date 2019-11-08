using System;

//例12 变长参数表
//使用变长参数，求若干个整数的平均值

namespace CSHARPEX12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Average(1));
            Console.WriteLine(Average(1, 2, 3, 4));
        }
        static double Average(params int[] a)
        {
            int b = a.GetLength(0);
            double s = 0;
            foreach (int k in a)
                s += k;
            return s / b;
        }
    }
}

