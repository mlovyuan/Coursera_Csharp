using System;

//例2随机填充一维数组
//产生100个1-99之间的随机整数，填充数组；
//数组类型是整数，大小为100

namespace CSHARPEX02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 100);
            }

            foreach (int k in a)
            {
                Console.Write("{0} ", k);
            }
        }
    }
}