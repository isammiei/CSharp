using System;

namespace _039_参数数组
{
    class Program
    {
        static int Add(params int[] array)
        {
            int sum = 0;
            foreach(int temp in array)
            {
                sum += temp;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Add(1, 2, 3, 4, 5);
            Console.WriteLine(sum);
        }
    }
}
