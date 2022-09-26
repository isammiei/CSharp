using System;

namespace _049_委托
{
    class Program
    {
        static double Multiply(double param1,double param2)
        {
            return param1 * param2;
        }
        static double Divide(double param1,double param2)
        {
            return param1 / param2;
        }
        static void Test()
        {
            Console.WriteLine("Test");
        }
        delegate double MyDelegate(double param1, double param2);
        delegate void MyDelegate2();
        static void Main(string[] args)
        {
            MyDelegate delegate1;
            delegate1 = Multiply;
            MyDelegate delegate2;
            delegate2 = Divide;
            MyDelegate2 delegate3;
            delegate3 = Test;
            Console.WriteLine(delegate1(2, 4));
            Console.WriteLine(delegate2(2, 4));
            delegate3();
        }
    }
}
