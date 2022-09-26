using System;
using System.Collections.Generic;
using System.Text;

namespace _009_抽象类
{
    public class Boss : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Boss进行攻击");
        }
    }
}
