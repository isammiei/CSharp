using System;

namespace _041_方法的重载
{
    class Program
    {
        static int MaxValue(int[] array)
        {
            int max = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static double MaxValue(double[] array)
        {
            double max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxValue(new int[] { 12, 13, 2, 22 }));
            Console.WriteLine(MaxValue(new double[] { 12, 13, 2, 22.5 }));
        }
    }
}
