using System;

namespace _024_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //回⽂数指正序（从左到右）和倒序（从右到左）读都是⼀样的整数。输⼊⼀个数，判断是否是回 ⽂数。输⼊的整数⼤于0，⼩于1000000。如果是回⽂输出yes，不是输出no。
            //样例输⼊ 2397 输出no 样例输⼊ 2992 样例输出yes
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int number = 0;
            while (temp != 0)
            {//7 70 79 790
                int i = temp % 10;
                number *= 10;
                number += i;

                temp /= 10;
            }
            if (num == number)
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
