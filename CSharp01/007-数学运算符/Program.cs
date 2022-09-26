using System;

namespace _007_数学运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 45 / 10;
            //double f = 45 / 10.0;
            //Console.WriteLine("a=" + a);
            //Console.WriteLine("f=" + f);

            int num = 39;
            int ge = num % 10;
            int shi = num / 10;
            Console.WriteLine("39的个位数是{0}，十位数是{1}", ge, shi);
        }
    }
}
