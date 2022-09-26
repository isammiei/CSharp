using System;

namespace _019_while循环_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            ////2006年培养学员80000⼈，每年增⻓25%，请问按此增⻓速度，到哪⼀年培训学员⼈数将达到20万⼈？
            //int i = 80000;
            //int year = 2006;
            //while (i < 200000)
            //{
            //    i = (int)(i* 1.25);
            //    year++;
            //}
            //Console.WriteLine(year);

            ////班上有若⼲名学⽣，输⼊学⽣的个数，然后输⼊每⼀个学⽣的年龄，计算出来平均年龄，保留到 ⼩数点后两位，输出平均年龄。
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //double ave = 0;
            //while (i <= num)
            //{
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    sum += age;
            //    i++;
            //}

            //ave = 1.0*sum / num;
            ////4.4532-> 445.32-> 445-> 4.45
            //ave = ((int)(ave * 100)) / 100.0;
            //Console.WriteLine(ave);

            //输⼊⼀个整数n，输出1~n中的每个数，空格隔开。
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i <= n)
            {
                Console.Write(i + " ");
                i++;
            }
        }
    }
}
