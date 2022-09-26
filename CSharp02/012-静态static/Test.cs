using System;
using System.Collections.Generic;
using System.Text;

namespace _012_静态static
{
    class Test
    {
        public int hp;
        public static int count;
        //静态函数只能使用静态数据
        public static void Move()
        {
            Console.WriteLine(count);
            Console.WriteLine("Move");
        }
    }
}
