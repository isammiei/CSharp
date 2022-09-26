using System;
using System.Collections.Generic;
using System.Text;

namespace _009_抽象类
{
    public abstract class Enemy
    {
        private int hp;
        private int speed;
        public void Move()
        {
            Console.WriteLine("Move");
        }
        public abstract void Attack();
    }
}
