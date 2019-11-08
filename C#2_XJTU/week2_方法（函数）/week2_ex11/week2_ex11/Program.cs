using System;

//例11 可选参数和命名参数
//说明可选参数和命名参数

namespace CSHARPEX11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            double b = 45;
            int c = 23;
            char d = 'Y';
            Sam(a, b, c, d);
            Sam(a, b, c); //right
            Sam(a, b, 1, d);
            Sam(a, b, d: d); //命名参数
            Sam(a, b, c: 12);
        }
        static void Sam(int a, double b, int c = 1, char d = 'R')
        {
            a = a + 1;
            b = a + c;
        }
    }
}

