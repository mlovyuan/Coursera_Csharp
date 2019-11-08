using System;

//例7 静态方法和静态变量
//说明静态方法和静态变量的例子

namespace CSHARPEX07

{
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            Sample s1 = new Sample();
            //s.SampleMethod(); //error
            Sample.SampleMethod();
            Console.WriteLine(Sample.count++);
        }
    }
    class Sample
    {
        public static int count = 0;
        public int a = 0;
        public static void SampleMethod()
        {
            Console.WriteLine("The Static Method");
        }
        public Sample()
        {
            count++;
        }
    }
}