using System;

namespace _017_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            ////编写⼀个程序，对输⼊的4个整数，求出其中的最⼤值和最⼩值，并显⽰出来。
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int max = a;
            //int min = d;
            //if (b > a)
            //{
            //    max = b;
            //}
            //if (c > b)
            //{
            //    max = c;
            //}
            //if (d > c)
            //{
            //    max = d;
            //}
            //if (c < d)
            //{
            //    min = c;
            //}
            //if (b < c)
            //{
            //    min = b;
            //}
            //if (a < b)
            //{
            //    min = a;
            //}
            //Console.WriteLine("最大值为{0},最小值为{1}", max, min);

            //让⽤户输⼊两个整数，然后再输⼊0-3之间的⼀个数，0代表加法，1代表减法，2代表乘法，3代 表除法,计算这两个数字的结果
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 0:
                    Console.WriteLine(a + b);
                    break;
                case 1:
                    Console.WriteLine(a - b);
                    break;
                case 2:
                    Console.WriteLine(a * b);
                    break;
                case 3:
                    Console.WriteLine((a * 1.0) / b);
                    break;
            }
        }
    }
}
