using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//电梯计算。某城市最高的楼只有一部电梯。该电梯和一般电梯不同的是它依照输入楼层数的先后次序运行。
//电梯最初在0层。运行完一个输入序列后就停止在该楼层，不返回0层。编写程序计算电梯运行一个序列的时间。
//每次都假设电梯在0层开始，无论上一次运行到几层。电梯每上1层需要6秒。每下1层需要4秒。如在某层停留，无论上下人多少，
//均停留5秒。输入：程序可以输入多行。每行的第一个数N指示后面将有N个楼层的序列。楼层的值大于等于1，小于100。
//N=0表示结束输入。输出：计算每个序列电梯运行的时间。



namespace week_hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please type number of elevator's sequence : ");
                var input = Console.ReadLine();
                var a = input.Split(' ');
                int[] input1 = new int[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    input1[i] = Convert.ToInt32(a[i]);
                }
                int up = 0, down = 0, temp = 0;
                while (input1[0] > 0)
                {
                    for(int i = 1; i < input1.Length; i++)
                    {
                        if(input1[i] > temp)
                        {
                            up += input1[i]-temp;
                            temp = input1[i];
                        }
                        else
                        {
                            down += temp - input1[i];
                            temp = input1[i];
                        }
                    }
                    Console.WriteLine($"All time of elevator running is {up * 6 + down * 4 + (input1.Length - 1) * 5}");
                    break;
                }
            }
        }
    }
}
