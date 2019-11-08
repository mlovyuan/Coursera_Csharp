using System;

//例13 方法的重载
//Overload（重载）
//方法参数数目不同；
//方法拥有相同数目的参数，但参数的类型不一样；
//方法拥有相同数目的参数和参数类型，但是参数类型出现的先后顺序不一样。
//构成重载的方法与方法的返回值类型无关。

namespace CSHARPEX13
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = TriangleArea(3d, 4d, 5d);
            double area2 = TriangleArea(3, 4, 5);
        }
        static double TriangleArea(double a, double b, double c)
        {
            Console.WriteLine("3");
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        static double TriangleArea(double a, double h)
        {
            Console.WriteLine("2");
            return (a * h) / 2;
        }

        static double TriangleArea(int a, int b, double theta)
        {
            Console.WriteLine("1");
            return (a * b * Math.Sin(theta)) / 2;
        }
    }
}

