using System;
using System.Collections.Generic;
using System.Text;

namespace _007_继承
{
    class Enemy
    {
        protected int hp;//private protected public
        protected int speed;
        public void AI()
        {
            Console.WriteLine("AI");
        }
        public void Move()
        {
            Console.WriteLine("Move");
        }
    }
}
