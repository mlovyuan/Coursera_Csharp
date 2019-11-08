using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//输入两个整型数组（假设数组的大小为不超过10）的各个元素，输出不是两个数组共有的元素，并从小到大排序输出。
//输入： 2个数组的个元素（小于10个），分2行输入;
//输出：非共有的元素,从小到大排序

namespace week1_hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一次輸入
            Console.Write("Please type in 10 numbers here: ");
            string x = Console.ReadLine();
            int[] input1 = FirstType(x);

            //第二次輸入
            Console.Write("Type others 10 numbers here: ");
            string y = Console.ReadLine();
            int[] input2 = FirstType(y);
            

            var diff = input1.Except(input2).Union(input2.Except(input1)).OrderBy((g) => g);
            Console.WriteLine("The different numbers in two arrays are: ");
            foreach (var k in diff)
            {
                Console.Write(k+"\n");
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
