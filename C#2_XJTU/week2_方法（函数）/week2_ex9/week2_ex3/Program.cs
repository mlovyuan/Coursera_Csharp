using System;

//例9 方法的参数传递
//引用类型的参数传递

namespace CSHARPEX09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            AddOne(a);
            //AddOne2(ref a);
            foreach (int k in a)
            Console.WriteLine(k);
        }
        static void AddOne(int[] a)
        {
            a = new int[4] { 11, 12, 13, 14 };
            for (int i = 0; i < a.Length; i++)
            {
                a[i]++;
            }
        }
        static void AddOne2(ref int[] a)
        {
            a = new int[4] { 11, 12, 13, 14 };
            for (int i = 0; i < a.Length; i++)
            {
                a[i]++;
            }
        }
    }
}