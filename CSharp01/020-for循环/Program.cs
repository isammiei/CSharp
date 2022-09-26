using System;

namespace _020_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            ////循环输出1-10
            //for(int i = 1; i < 11; i++)
            //{
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine();
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i+" ");
            //}

            ////输出20个*，在同⼀⾏
            //for(int i = 1; i < 21; i++)
            //{
            //    Console.Write("*");
            //}

            ////利⽤for循环计算1-100的和
            //int sum = 0;
            //for(int i = 1; i < 101; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            ////利⽤for循环输出1 - 100之间所有的偶数
            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            //输⼊两个正整数n和m，计算n和m之间（包含n和m）所有能被17整除的数的和，并输出和。
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for(int i = n; i < m + 1; i++)
            //{
            //    if (i % 17 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);

            //输⼊两个正整数n和m，利⽤for循环打印出来n和m之间（包含n和m），所有的奇数和所有的 偶数。奇数放在⼀⾏，⽤空格分割。偶数放在⼀⾏，⽤空格分割。
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            string even ="";
            string odd = "";
            for (int i = n; i < m + 1; i++)
            {
                if (i % 2 == 1)
                {
                    odd += i+" ";
                }
                else
                {
                    even += i+" ";
                }
            }
            Console.Write(odd);
            Console.WriteLine();
            Console.Write(even);































        }
    }
}
