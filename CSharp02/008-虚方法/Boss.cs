using System;
using System.Collections.Generic;
using System.Text;

namespace _008_虚方法
{
    class Boss:Enemy
    {
        public override void Move()
        {
            Console.WriteLine("Boss特有的Move方法");
        }
        public new void AI()
        {
            Console.WriteLine("Boss特有的AI");
        }
    }
}
