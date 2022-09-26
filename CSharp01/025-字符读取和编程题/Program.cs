using System;

namespace _025_字符读取和编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            ////数字和字符混合在⼀起了，作为⼀个优秀的挖掘⼈员，把输⼊的数字挖出来，并计算这些数字的 和，并输出。
            ////输⼊以@作为结束。 样例输⼊ 23a34b34@ 样例输出 19
            //char c;
            //int sum = 0;
            //do
            //{
            //    c = (char)Console.Read();
            //    if (c >= '0' && c <= '9')
            //    {
            //        sum += c - '0';
            //    }
            //} while (c!='@');
            //Console.WriteLine(sum);

            ////假设有个隧道，隧道以字符 ‘#’ 结束，挖矿的过程中，会遇到钻⽯ ‘*’ 和美⾦ ‘1’ ~ ‘9’ ，让矿⼯ ⼩六挖到隧道的尽头，假设每个钻⽯价值500美⾦，统计⼩六挖到了价值多少美⾦的收获？
            ////样例输⼊ ka4d*s6kkl8s*d9fyo# 样例输出 1027
            //char c;
            //int sum = 0;
            //do
            //{
            //    c = (char)Console.Read();
            //    if (c >= '0' && c <= '9')
            //    {
            //        sum += c - '0';
            //    }else if(c=='*'){
            //        sum += 500;
            //    }
            //} while (c != '#');
            //Console.WriteLine(sum);

            ////输⼊⼀个整数，输出该整数的因数个数和所有因数。
            //int a = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //String str = "";
            //for(int i = 1; i <= a; i++)
            //{
            //    if (a % i == 0)
            //    {
            //        count++;
            //        str += i + " ";
            //    }
            //}
            //Console.WriteLine(count);
            //Console.WriteLine(str);

            //输⼊⼀个正整数，判断该数是否是质数。
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }









        }
    }
}
