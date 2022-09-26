using System;

namespace _026_循环中的continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //continue 中止当前循环 继续执行下一个循环
            //输出1-100中所有的奇数，使⽤continue。
            for(int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
