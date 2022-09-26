using System;

namespace _003_变量
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 8;
            Console.WriteLine(a + b);
            Console.WriteLine("a + b");
            Console.WriteLine(a + "+" + b);
            Console.WriteLine("a+b" + a + b);
            Console.WriteLine("a+b" + (a + b));
        }
    }
}
