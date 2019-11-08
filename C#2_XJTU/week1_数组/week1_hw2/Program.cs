using System;

namespace week1_hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 100);
            }

            int max = a[0], min = a[0], maxi = 0, mini = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    mini = i;
                }
                else if (a[i] > max)
                {
                    max = a[i];
                    maxi = i;
                }
            }
            Console.WriteLine("The maximum is {0}, which is located on {1}. \n The minimum is {2}, which is located on {3}.", max, maxi, min, mini);
        }
    }
}
