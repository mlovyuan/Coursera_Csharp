using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//利用二维数组求解问题。一家公司有4名售货员（编号为1-4），卖5种不同的产品（编号为1-5）。每天，对于每种不同产品的销售情况，
//每位售货员都要递交一张相应的纸条。每张纸条包含以下内容：
//a)售货员编号
//b)产品编号
//c)该产品当天的销售总额
//因此，每位售货员每天会上交0-5张销售纸条。假设现在有上个月所有纸条信息。请编写一个程序，读入上个月的销售信息，
//统计每位售货员每种产品的销售总额。所有的总额应存储在一个二维数组sales中。处理完上个月的信息后，以表格形式打印出结果，
//每列表示一位售货员，每行表示一种产品。统计每行求出上个月每种产品的销售总额；统计每列求出上个月每位售货员的销售总额。
//打印输出的表格应该在相应行的右边和相应列的下面显示这些统计结果。



namespace week1_hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int column = 4, row = 5;
            //假设现在有上个月所有纸条信息
            int[,] init = new int[row, column] { { 10, 20, 30, 40 }, { 40, 30, 20, 10 },
                { 11, 12, 13, 14 }, { 15, 16, 17, 18 }, { 5, 10, 15, 20 } };
            int[,] results = new int[row + 1, column + 1];
            for (int i = 0; i < row; i++)
            {
                int temp = 0;
                for (int j = 0; j < column+1; j++)
                {
                    if (j == column)
                    {
                        results[i, j] = temp;
                        break;
                    }
                    results[i, j] = init[i, j];
                    temp += init[i,j];
                }
            }
            for (int i = 0; i < column+1; i++)
            {
                int temp = 0;
                for (int j = 0; j < row + 1; j++)
                {
                    if (j == row)
                    {
                        results[j, i] = temp;
                        continue;
                    }
                    temp += results[j, i];
                }
            }
            for (int i = 0; i < row+1; i++)
            {
                for (int j = 0; j < column + 1; j++)
                {
                    Console.Write(results[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
