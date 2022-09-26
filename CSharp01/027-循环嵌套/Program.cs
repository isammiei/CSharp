using System;

namespace _027_循环嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
            ////输出 ⼀⾏ 10个*
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}

            ////输出4⾏ 每⾏10个*
            //for(int i = 0; i < 4; i++)
            //{
            //    for(int j = 0; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////输⼊两个整数n和m，输出n⾏m列的*阵
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());

            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < m; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////输⼊整数n，输出n层的三⾓形的斜边。
            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i < n + 1; i++)
            //{
            //    for(int j = 0; j < i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}

            ////输⼊整数n，输出n层的三⾓形的斜边。
            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i = n; i > 0; i--)
            //{
            //    for(int j = 0; j < i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}

            ////输⼊正整数n，输出n⾏，每⾏n个*的平⾏四边形。
            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i < n + 1; i++)
            //{
            //    for(int j = 0; j < i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = 1; j < n+1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////输⼊⼀个正整数n，输出n层的右三⾓形。
            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i < n + 1; i++)
            //{
            //    for(int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////输⼊⼀个正整数n，输出n层的等腰三⾓形。
            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i < n + 1; i++)
            //{
            //    for(int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////输⼊⼀个正整数n，输出n层的菱形。
            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i < n + 1; i++)
            //{
            //    for(int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i = 1; i <= n - 1; i++)
            //{
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    //n-1-i+1=n-i总行号-当前行号+1  *2-1
            //    int countStar = 2 * (n - i) - 1;
            //    for(int j = 0; j < countStar; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////输出9x9乘法表。
            //for(int i = 1; i <= 9; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}*{1}={2} ", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}

            ////⽤100⽂买鸡，其中公鸡，⺟鸡，⼩鸡，都必须要有，公鸡3⽂⼀只，⺟鸡5⽂⼀只，⼩鸡 2⽂⼀只，请问公鸡、⺟鸡、⼩鸡要买多少只刚好凑⾜100⽂。 把所有的满⾜条件的情况罗列出来。
            //for(int x = 1; x < 100 / 3; x++)
            //{
            //    for(int y = 1; y < 100 / 5; y++)
            //    {
            //        for(int z = 1; z < 100 / 2; z++)
            //        {
            //            if ((3 * x + 5 * y + 2 * z) == 100)
            //            {
            //                Console.WriteLine("公鸡{0}只，母鸡{1}只，小鸡{2}只", x, y, z);
            //            }
            //        }
            //    }
            //}

            //输⼊两个整数num1和num2，输出这两个正整数num1和num2的最⼤公约数。
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int min = num1;
            if (num2 < num1)
            {
                min = num2;
            }
            for(int i = min; i > 0; i--)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    Console.WriteLine("最大公约数{0}",i);
                    break;
                }
            }














        }
    }
}
