using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//随机出10道100以内的加减法题目，要求用户回答。每次回答1题，
//用户给出答案后出下一题。10道题完成后，每题10分，给出用户的成绩

namespace week1_hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Q= 0;
            int scorce = 0;
            Console.WriteLine("There are 10 questions here need you to answer");
            while (Q < 10)
            {
                Random r = new Random();
                int a = r.Next(101), b = r.Next(101), c = r.Next(2);
                string q = c == 0 ? "+" : "-";
                Console.Write($"{a}{q}{b}=");
                int uans = Convert.ToInt32(Console.ReadLine());
                var ans = c == 0 ? a + b : a - b;
                scorce += uans == ans ? 10 : 0;
                Q++;

            }
            Console.WriteLine($"Your score is {scorce}");
            Console.ReadLine();
        }
    }
}
