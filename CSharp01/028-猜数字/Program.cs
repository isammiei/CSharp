using System;

namespace _028_猜数字
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            //Console.WriteLine(rd.Next(1, 10));
            int number = rd.Next(1, 101);
            while (true)
            {
                Console.WriteLine("猜猜我的数字是多少");
                int numUser = Convert.ToInt32(Console.ReadLine());
                if (numUser > number)
                {
                    Console.WriteLine("你猜大了");
                }else if (numUser < number)
                {
                    Console.WriteLine("你猜小了");
                }
                else
                {
                    Console.WriteLine("你猜对了");
                    break;
                }
            }
        }
    }
}
