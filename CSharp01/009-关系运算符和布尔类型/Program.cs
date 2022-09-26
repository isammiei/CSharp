using System;

namespace _009_关系运算符和布尔类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool a = true;//是的 真的 满足条件 1
            //bool b = false;//不是 假的 不满足条件 0
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            bool a = 12 == 34;
            bool b = 12 <= 34;
            bool c = 12 >= 34;
            bool d = 12 < 34;
            bool e = 12 > 34;
            bool f = 12 != 34;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

        }
    }
}
