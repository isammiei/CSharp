using System;
using System.Collections.Generic;
using System.Text;

namespace _008_虚方法
{
    class Enemy
    {
        public virtual void Move()
        {
            Console.WriteLine("Move");
        }
        public void AI()
        {
            Console.WriteLine("敌人的AI");
        }
    }
}
