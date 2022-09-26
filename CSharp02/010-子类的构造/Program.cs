using System;
using _009_抽象类;

namespace _010_子类的构造
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrivedClass dc = new DrivedClass();
            //DrivedClass dc = new DrivedClass(100);
            DrivedClass dc = new DrivedClass(100,80,10);
            //1、添加别的项目的引用，2、引用命名空间，3、把类设置为public
            Boss b = new Boss();
        }
    }
}
