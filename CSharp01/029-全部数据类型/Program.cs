using System;

namespace _029_全部数据类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte a = 100;
            //byte b = 100;

            //float f = 4.5f;
            //f = 2123456789;
            //Console.WriteLine(f);

            byte a = 23;
            int b = 300;
            //b = a;//隐式转换
            a = (byte)b;//显式转换
            //Console.WriteLine(b);
            Console.WriteLine(a);

            int i = Convert.ToInt32(Console.ReadLine());
            double j = Convert.ToDouble(Console.ReadLine());

            string str1 = 123 + "";
            string str2 = Convert.ToString(Console.ReadLine());

        }
    }
}
