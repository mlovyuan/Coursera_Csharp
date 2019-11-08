using System;

//例8 方法的参数传递
//参数是值类型的值传递和引用传递

namespace CSHARPEX08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 99;
            //Swap(a, b);
            Swap2(ref a, ref b);
            Console.WriteLine("a={0} && b={1}", a, b);
        }

        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a={0} && b={1}", a, b);
        }

        static void Swap2(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a={0} && b={1}", a, b);
        }
    }
}