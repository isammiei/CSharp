using System;
using System.Collections.Generic;
using System.Text;

namespace _007_继承
{
    class Boss:Enemy
    {
        private int attack;

        public Boss(int attack,int hp,int speed)
        {
            this.attack = attack;
            //this.hp = hp;
            //this.speed = speed;
            //base访问父类成员
            base.hp = hp;
            base.speed = speed;
        }

        public void Skill()
        {
            Console.WriteLine("Skill");
        }
        public void Print()
        {
            Console.WriteLine("HP:"+hp);
            Console.WriteLine("Speed:"+speed);
            Console.WriteLine("Attack:"+attack);
        }
    }
}
