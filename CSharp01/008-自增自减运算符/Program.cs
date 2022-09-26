using System;

namespace _008_自增自减运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //Console.WriteLine(a);


            int a = 5;
            //a++;
            //++a;
            //int b = a;
            //Console.WriteLine(a++);//a++先赋值再自增
            //Console.WriteLine(a);

            Console.WriteLine(++a);//++a先自增再赋值
            Console.WriteLine(a);
        }
    }
}
