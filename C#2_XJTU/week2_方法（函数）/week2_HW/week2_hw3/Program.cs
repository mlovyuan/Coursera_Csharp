using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//闰年计算。程序输入一个正整数Y，以及另一个正整数N。计算从Y年开始后的第N个闰年是哪一年（
//如果Y本身是闰年，则Y之后的第一个闰年是Y）。程序输入：程序可以多次计算，首先输入一个数K指示计算的次数，
//随后每行输入一个Y和N用空格分隔，做K次计算输出K个结果。（K>=1 && K<=100，N>=1 && N<=10000

namespace week2_hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please type a number you want to run this program: ");
            var input = Console.ReadLine();

            var record = Record(int.Parse(input));
            for(int i = 0; i < int.Parse(input); i++)
            {
                int temp = 0;
                while(DateTime.IsLeapYear(record[i][0]) == true)
                {
                    record[i][0]++;
                    if (DateTime.IsLeapYear(record[i][0]) == true)
                        break;
                }
                temp = record[i][0] + record[i][1] * 4 ;
                while (DateTime.IsLeapYear(temp) != true)
                {
                    temp++;
                    if (DateTime.IsLeapYear(temp) == true)
                    {
                        break;
                    }
                }
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }

        static List<int[]> Record(int input)
        {
            var record = new List<string[]>();
            for (int i = 0; i < input; i++)
            {
                Console.Write("please type the year and period: ");
                var year_period = Console.ReadLine();
                record.Add(year_period.Split());
            }

            var record_c = new List<int[]>();
            for (int i = 0; i < input; i++)
            {
                var a = new int[] { int.Parse(record[i][0]), int.Parse(record[i][1]) };
                record_c.Add(a); 
            }
            return record_c;
        }
    }
}
