using System;

namespace _007_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass bc = new BaseClass();
            //bc.Function1();
            //bc.Function2();
            //DrivedClass1 dc1 = new DrivedClass1();
            //dc1.Function1();
            //dc1.Function2();
            //DrivedClass2 dc2 = new DrivedClass2();
            //dc2.Function1();
            //dc2.Function2();

            Boss boss1 = new Boss(100,10000,2);
            boss1.Print();
        }
    }
}
