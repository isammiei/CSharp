using System;

namespace _012_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int ge = a % 10;
            //int shi = (a / 10 )% 10;
            //int bai = a / 100;
            //int b = ge * 100 + shi * 10 + bai;
            //Console.WriteLine(b);

            //int num = Convert.ToInt32(Console.ReadLine());
            //int shi = (num / 10)%10;
            //int qian = (num / 1000)%10;
            //int b = qian * 10 + shi;
            //char c = (char)b;
            //Console.WriteLine(c);

            int mathScore = Convert.ToInt32(Console.ReadLine());
            int englishScore = Convert.ToInt32(Console.ReadLine());
            bool isGetAward = mathScore >= 90 && englishScore >= 90;
            Console.WriteLine(isGetAward);

        }
    }
}
