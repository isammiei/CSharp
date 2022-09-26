using System;

namespace _018_循环语句_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            ////死循环
            //int i = 1;
            //while (true)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////换行输出1-9
            //int i = 1;
            //while (i<10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////如何换⾏输出1 - 100 1 - 1000
            //int i = 1;
            //while (i <= 100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////敌⼈攻击的AI： 当主⾓⾎量⼤于0的时候，就⼀直攻击主⾓。
            //int HP = 100;
            //while (HP > 0)
            //{
            //    HP -= 3;
            //    Console.WriteLine("HP:{0}", HP);
            //}

            ////输出100-1
            //int i = 100;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            ////输⼊整数n，计算1+2+3+...+n的和
            ////int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //int n = Convert.ToInt32(Console.ReadLine());
            //while (i<n+1)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            ////输出1-100之间所有的偶数
            //int i = 1;
            //while (i < 101)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            ////输⼊两个整数n1,n2,输出n1-n2(包含n1和n2)之间所有的偶数。
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int i = n1;
            //while (i < n2 + 1)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //3n+1问题：对于任意⼤于1的⾃然数n，若n为奇数，将n编程3n+1，否则变成n的⼀半。经过若 ⼲次这样的变化，n⼀定会最终变成1，⽐如，7 → 22 → 11 → 34 → 17 → 52 → 26 → 13 → 40→ 20 → 10 → 5 → 16 → 8 → 4 →2 → 1
            int n = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            while (n != 1)
            {
                if (n % 2 == 1)
                {
                    n = 3 * n + 1;
                }
                else
                {
                    n /= 2;
                }
                Console.WriteLine("转换后的值为"+n);
                j++;
            }
            Console.WriteLine("转换次数为" + j);
        }
    }
}
