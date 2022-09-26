using System;

namespace _023_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            ////让⽤户输⼊整数，如果⽤户输⼊的不是0，就继续输⼊，如果输⼊的是0，结束整数，并输出所 有整数的和。
            //int num = 0;
            //int sum = 0;
            //do
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    sum += num;
            //} while (num!=0);
            //Console.WriteLine(sum);

            ////输⼊⼀个整数a，和⼀个正整数n，计算乘⽅ a的n次⽅。
            //int a = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //int res = 1;
            //for(int i = 1; i <= n; i++)
            //{
            //    res *= a;
            //}
            //Console.WriteLine(res);

            ////输⼊整数n，输出n的阶乘。
            //int n = Convert.ToInt32(Console.ReadLine());
            //int res = 1;
            //for(int i = 1; i <= n; i++)
            //{
            //    res *= i;
            //}
            //Console.WriteLine(res);

            ////输⼊q和n，求下⾯公式的结果。
            //int q = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 1;
            //int temp = 1;
            //for(int i = 1; i <= n; i++)
            //{
            //    temp *= q;
            //    sum += temp;
            //}
            //Console.WriteLine(sum);//3 3 1+3+9+27=40

            ////我国现有x亿⼈⼝，按照每年0.1%的增⻓速度，n年后将有多少⼈？
            //double x = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i = 0; i < n; i++)
            //{
            //    x *= 1.001;
            //}
            //Console.WriteLine(x);

            ////编写⼀个程序，打印出所有的“⽔仙花数”，所谓“⽔仙花数”是指⼀个三位数，其各位数字⽴⽅等 于该数本⾝。例如153=1*1*1+5*5*5+3*3*3，所以153是“⽔仙花数”。
            //for(int i = 100; i < 999; i++)
            //{
            //    int ge = i % 10;
            //    int shi = (i / 10) % 10;
            //    int bai = i / 100;
            //    if (ge * ge * ge + shi * shi * shi + bai * bai * bai == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////输⼊任意⼀个位数未知的整数，输出这个数每⼀位上的数字。输出的时候，从个位开始输出，每 输出⼀个数字换⼀⾏。
            //int num = Convert.ToInt32(Console.ReadLine());
            ////1234
            ////4 123
            ////3 12
            ////2 1
            ////1 0
            //while (num!=0)
            //{
            //    int i = num % 10;
            //    Console.WriteLine(i);
            //    num /= 10;
            //}

            ////随机输⼊⼀个位数未知的整数，去除这个整数各个位上的0，形成新的数，并输出。 输⼊的数字n⼤于0，⼩于1000000。
            ////样例输⼊ 20603 样例输出 263
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int temp = 1;
            //while (num!=0)
            //{
            //    int i = num % 10;
            //    if (i != 0)
            //    {
            //        i *= temp;
            //        sum += i;
            //        temp *= 10;
            //    }
            //    num /= 10;
            //}
            //Console.WriteLine(sum);

            //随机输⼊⼀个整数num，输出⼀个新的数，新数恰好与原数每⼀位上的数字相反。（如果原数末 尾有多个零，输出的新数⾼位不含0）
            //23407800
            int num = Convert.ToInt32(Console.ReadLine());
            bool yudao = false;
            while (num != 0)
            {
                int i = num % 10;
                if (yudao == false)
                {
                    if (i!=0)
                    {
                        Console.WriteLine(i);
                        yudao = true;
                    }  
                }
                else
                {
                    Console.WriteLine(i);
                }
                num /= 10;
            }
        }
    }
}
