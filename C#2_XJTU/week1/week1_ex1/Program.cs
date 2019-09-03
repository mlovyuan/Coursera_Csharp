using System;

//例1求一维数组中的最大值
//假设一维数组元素如下：87，65，78，90，57和89。
//求最大值
//从键盘输入若干个数（以空格分隔，求最大值）

namespace CSHARPEX01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = new int[6] { 87, 65, 78, 90, 57, 89 };
            //int[] a = new int[] { 87, 65, 78, 90, 57, 89 };
            //int[] a ={ 87, 65, 78, 90, 57, 89 };
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int[] a = new int[ss.Length];
            for (int i = 0; i < ss.Length; i++)
            {
                a[i] = Convert.ToInt32(ss[i]);
            }

            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("The Max is {0}", max);
        }
    }
}

