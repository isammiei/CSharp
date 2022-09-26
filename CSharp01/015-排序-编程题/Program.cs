using System;

namespace _015_排序_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            ////输⼊三个整数，把这三个数，从⼩到⼤排序后输出。 输⼊：8 3 5 输出 3 5 8
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}
            //if (b > c)
            //{
            //    int temp = b;
            //    b = c;
            //    c = temp;
            //}
            //if (a > b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}
            //Console.WriteLine(a + " " + b + " " + c);

            //输⼊⼀个⼩数m和整数k（k为0,1） 如果k为0，则输出m保留整数部分。 如果k为1，则输出m，四舍五⼊保留1为⼩数。 样例输⼊ 4.65 0 输出 4输⼊ 4.65 1 输出4.7
            double m = Convert.ToDouble(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            if (k == 0)
            {
                int temp = (int)m;
                Console.WriteLine(temp);
            }
            //3.2543+0.05 = 3.3, 3.3*10=33, 33/10=3.3 
            else
            {
                double temp = ((int)((m + 0.05) * 10))/ 10.0;
                Console.WriteLine(temp);
            }
        }
    }
}
