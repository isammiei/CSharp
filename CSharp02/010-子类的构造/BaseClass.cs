using System;
using System.Collections.Generic;
using System.Text;

namespace _010_子类的构造
{
    class BaseClass
    {
        private int hp;
        private int speed;
        public BaseClass()
        {
            Console.WriteLine("构造方法:BaseClass");
        }

        public BaseClass(int hp, int speed)
        {
            this.hp = hp;
            this.speed = speed;
        }
    }
}
