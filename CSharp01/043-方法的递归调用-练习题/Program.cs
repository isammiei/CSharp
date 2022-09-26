using System;

namespace _043_方法的递归调用_练习题
{  
    class Program
    {
        //利⽤递归取得10!
        static int F(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int result = n * F(n - 1);
            return result;
        }
        
        //1+2!+3!+...+20!
        static int F1(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int result = n * F1(n - 1);
            return result;
        }
        static int F2(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return F2(n - 1) + F1(n);
        }

        static void Main(string[] args)
        {
            //int result = 1;
            //for(int i = 1; i < 11; i++)
            //{
            //    result *= i;
            //}
            //Console.WriteLine(result);
            //Console.WriteLine(F(10));


            //int total = 0;
            //for(int i = 1; i < 11; i++)
            //{
            //    int temp = 1;
            //    for(int j = 1; j < i + 1; j++)
            //    {
            //        temp = temp * j;
            //    }
            //    total += temp;
            //}
            //Console.WriteLine(total);
            Console.WriteLine(F2(10));
        }
    }
}
