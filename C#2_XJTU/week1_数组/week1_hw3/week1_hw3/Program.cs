using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//利用一维数组求解问题。读入20个数，每个数在10-100之间包括10和100。在读入每个数时，
//确认这个数的有效性，并且若它和之前读入的数不一样，就把它存储到数组中。读完所有数之后，仅显示用户输入的不同的数值。

namespace week1_hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一次輸入
            Console.Write("請輸入你的20個數:");
            string x = Console.ReadLine();
            int[] input1 = FirstType(x);

            //第二次輸入
            Console.Write("請輸入你剛剛記得的數:");
            string y = Console.ReadLine();
            int[] input2 = FirstType(y);

            var diff = input1.Except(input2);
            Console.WriteLine("少輸入: ");
            foreach (var k in diff)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
        static int[] FirstType(string x)
        {
            string[] xx = x.Split(' ');
            int[] b = new int[xx.Length];
            for (int i = 0; i < xx.Length; i++)
            {
                b[i] = Convert.ToInt32(xx[i]);
            }
            return b;
        }
    }
}
