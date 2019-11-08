using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//编写一个递归函数power（base,expoent），它在调用时返回baseexpoent
//例如，power（3，4）=3*3*3*3。假设expoent是大于或等于1的整数。
//提示：递归步骤将利用如下关系：
//base(expoent)=base.base(expoent)-1
//并在exponent等于1时终止递归，因为
//base1次方 = base

namespace week2_hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type a number and the times you want to get its exponent: ");
            var input = Console.ReadLine();
            var input1 = input.Split(' ');
            var rtn = Callmyself(int.Parse(input1[0]), int.Parse(input1[1]));
            Console.WriteLine($"Result is {rtn}");
            Console.ReadLine();
        }

        static int Callmyself(int num, int times)
        {
            if (times == 0)
            {
                return 1;
            }
            else
            {
                if (times > 1)
                {
                    times--;
                    var x = Callmyself(num, times);
                    x = num * x;
                    return x;
                }
                else
                {
                    return num;
                }
            }
        }
    }
}
