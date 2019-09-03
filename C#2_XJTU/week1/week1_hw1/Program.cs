using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string[] xx = x.Split(' ');
            int[] a = new int[xx.Length];

            for (int i = 0; i < xx.Length; i++)
            {
                a[i] = Convert.ToInt32(xx[i]);
            }

            int min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("The minimum is {0}", min);
        }
    }
}