using System;

namespace _008_虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boss b = new Boss();
            //b.Move();
            //Enemy enemy = new Boss();
            //enemy.Move();
            Boss b = new Boss();
            b.AI();
            Enemy enemy = new Boss();
            enemy.AI();
        }
    }
}
