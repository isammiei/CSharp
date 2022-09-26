using System;

namespace _010_逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            // &&与  ||或  !非
            bool a = (1 < 2) && (3 < 4);
            bool b = (1 < 2) || (3 > 4);
            bool c = !(1 < 2);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
