using System;

namespace _014_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //输⼊⼀个年份，判断该年是不是闰年。是的话输出Yes，不是的话输出No。
            //int year = Convert.ToInt32(Console.ReadLine());
            //if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            //{
            //    Console.WriteLine("闰年");
            //}
            //else
            //{
            //    Console.WriteLine("不是闰年");
            //}

            //输⼊⼀个⾮零整数，判断是正数还是负数，并输出它的绝对值
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number < 0)
            //{
            //    Console.WriteLine(0 - number);
            //}
            //else
            //{
            //    Console.WriteLine(number);
            //}

            //最⼤值：输⼊三个整数，求这个三个数中最⼤值的平⽅。
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int max;
            //max = a;
            //if (max < b)
            //{
            //    max = b;
            //}
            //if (max < c)
            //{
            //    max = c;
            //}
            //Console.WriteLine(max * max);

            ////任意给出两个⼤写英⽂字⺟，⽐较他们的⼤⼩。规定 A、B、C、....Z依次从⼩到⼤。
            //char a = Convert.ToChar(Console.ReadLine());
            //char b = Convert.ToChar(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine("{0}<{1}", b, a);
            //}
            //else
            //{
            //    Console.WriteLine("{0}<{1}", a, b);
            //}

            char sex = Convert.ToChar(Console.ReadLine());
            int number = Convert.ToInt32(Console.ReadLine());
            if (sex == 'F')
            {
                //Console.WriteLine("800米");
                string project = "800米";
                if (number % 2==0)
                {
                    //Console.WriteLine("仰卧起坐");
                    project += " 仰卧起坐";
                    Console.WriteLine(project);
                }
                else
                {
                    //Console.WriteLine("跳绳");
                    project += " 跳绳";
                    Console.WriteLine(project);
                }
            }
            else
            {
                Console.WriteLine("1000米");
                if (number % 2 == 0)
                {
                    Console.WriteLine("俯卧撑");
                }
                else
                {
                    Console.WriteLine("跳远");
                }
            }




        }
    }
}
