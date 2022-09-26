using System;

namespace _044_方法的递归调用_练习题
{
    class Program
    {
        //有关系式1*1+2*2+3*3+...+k*k<2000,编⼀个程序，求出满⾜此关系式的k的最⼤值
        static int F(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return F(n - 1) + n * n;
        }
        static void Main(string[] args)
        {
            //int k = 1;
            //int result = 0;
            //while (true)
            //{
            //    result += k * k;
            //    if (result >= 2000)
            //    {
            //        break;
            //    }
            //    k++;
            //}
            //Console.WriteLine(k - 1);


            int i = 1;
            while (true)
            {
                if (F(i) >= 2000)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(i - 1);
        }
    }
}
