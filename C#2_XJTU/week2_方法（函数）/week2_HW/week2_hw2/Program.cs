using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose your grade (1 or 2) : ");
            var input = Console.ReadLine();
            while (true)
            {
                if (input == "1")
                {
                    One();
                }
                if(input == "2")
                {
                    Two();
                }
            }
        }
        static void One()
        {
            Random r = new Random();
            int a = r.Next(1, 10), b = r.Next(1, 10);
            Console.WriteLine($"How much is {a} times {b}?");
            Judge(a, b);
        }
        static void Two()
        {
            Random r = new Random();
            int a = r.Next(10, 100), b = r.Next(10, 100);
            Console.WriteLine($"How much is {a} times {b}?");
            Judge(a, b);
        }
        static void Judge(int a, int b)
        {
            while (true)
            {
                int ans = Convert.ToInt32(Console.ReadLine());
                var result = ans == (a * b) ? "Very good!" : "No,Please try again.";
                Console.WriteLine(result);
                if (ans == (a * b))
                {
                    break;
                }
            }
        }
    }
}
