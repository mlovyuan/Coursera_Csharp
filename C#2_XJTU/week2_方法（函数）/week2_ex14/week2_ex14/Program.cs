using System;

//例14 递归
//用递归的方法求阶乘

namespace CSHARPEX14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fac(5));
        }
        static int Fac(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fac(n - 1);
        }
    }
}