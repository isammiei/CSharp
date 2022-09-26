using System;

namespace _022_变量的作用域
{
    class Program
    {
        static void Main(string[] args)
        {
            //局部变量 全局变量
            int i = 1;
            while (i < 11)
            {
                int sum = 0;
                Console.WriteLine(i);
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
