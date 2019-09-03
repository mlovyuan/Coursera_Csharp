using System;

//例4骰子的模拟
//程序应该先随机掷出第一个骰子，再随机掷出第二个骰子。然后计算两个值的和。
//（注意：由于每个骰子显示1-6之间的一个整数值，因此这两个值的和在2-12之间变动，
//其中7是出现频率最高的值，2-12是出现频率最低的值。）
//程序应该掷出这两个骰子3600次。请利用一个一维数组记录每个可能的和出现的次数。

namespace CSHARPEX04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] dice = new int[11];
            for (int i = 0; i < 3600; i++)
            {
                int d1 = r.Next(1, 7);
                int d2 = r.Next(1, 7);
                dice[d1 + d2 - 2]++;
            }

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("和是{0}的次數是{1}", i + 2, dice[i]);
            }
        }
    }
}