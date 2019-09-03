using System;

//例3在数组中顺序查找
//在例2生成的数组基础上，输入一个1-99之间的数；
//如果该数字在数组中，则输出该数字在数组中的下标；
//如果不在，输出-1；
//如果有多个，仅输出第一个匹配的下标

namespace CSHARPEX03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] a = new int[100];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 100);
            }

            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                if (m == a[i])
                {
                    Console.WriteLine("m的位置{0}", i);
                    return;
                }
            }

            Console.WriteLine("-1");
            return;
        }
    }
}