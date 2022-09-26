using System;

namespace _042_方法的递归调用
{
    
    class Program
    {
        static void Test()
        {
            Console.WriteLine("test1");
            Test();
            Console.WriteLine("test2");
        }
        //f(n)=f(n-1)+f(n-2) f(0)=2 f(1)=3 ,⽤程序求得f(40)
        static int F(int n)
        {
            if (n == 0)
            {
                return 2;
            }
            if (n == 1)
            {
                return 3;
            }
            int res = F(n - 1) + F(n - 2);
            return res;
        }
        static void Main(string[] args)
        {
            //int n1 = 3;
            //int n2 = 2;
            //int n = 0;
            //for(int i = 2; i < 41; i++)
            //{
            //    n = n1 + n2;
            //    n2 = n1;
            //    n1 = n;
            //}
            //Console.WriteLine(n);
            Console.WriteLine(F(40));
        }
    }
}
