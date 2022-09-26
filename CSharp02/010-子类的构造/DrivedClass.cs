using System;
using System.Collections.Generic;
using System.Text;

namespace _010_子类的构造
{
    class DrivedClass : BaseClass
    {
        private int attack;
        public DrivedClass()
        {
            Console.WriteLine("构造方法:DrivedClass");

        }

        public DrivedClass(int attack)
        {
            this.attack = attack;
        }
        public DrivedClass(int attack,int hp,int speed):base(hp,speed)
        {
            this.attack = attack;
        }
    }
}
