using System;

//例15 递归 汉诺塔
//如果n=1，直接将金片从A针移到C针上，函数输出
// Form A to C
//2. 如果n>1时，移动过程分解为以下几个步骤：
// (1) 将A上的n-1片金片借助C针移到B针上;
// (2) 把A针上剩下的一片金片由A针移到C针上;
// (3) 再将B上的n-1个金片借助A针由B针移到C针上。

namespace CSHARPEX15
{
    class Program
    {
        static void Main(string[] args)
        {
            hanoi(3, 'A', 'B', 'C');
        }
        static void Move(char from, char to)
        {
            Console.WriteLine("From {0} To {1}", from, to);
        }
        static void hanoi(int n, char p1, char p2, char p3)
        {
            if (n == 1)
            {
                Move(p1, p3);
            }
            else
            {
                hanoi(n - 1, p1, p3, p2);
                Move(p1, p3);
                hanoi(n - 1, p2, p1, p3);
            }
        }
    }
}