using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.Show();

            Time t2 = new Time(2, 34, 34);
            t2.Show();

            //t2.hour = 12; private 不能被直接访问
        }
    }

    public class Time

    {

        private int hour;
        private int minute;
        private int second;

        public void Show()

        {
            Console.WriteLine("{0:D2} : {1:D2} : {2:D2}", hour, minute, second);
        }

        public Time()

        {
            hour = minute = second = 0;
            Console.WriteLine("Default Construct");
        }

        public Time(int h, int m, int s)

        {
            hour = h >= 0 && h <= 24 ? h : 0;
            minute = m >= 0 && m <= 59 ? m : 0;
            s = s >= 0 && s <= 59 ? s : 0;
            Console.WriteLine("Construct");
        }
        
        //為了外不能修改hour，所以做出這個屬性
        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        ~Time()
        {
            Console.WriteLine("Destroy");
        }
    }
}

