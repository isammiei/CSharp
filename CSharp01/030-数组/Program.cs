using System;

namespace _030_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] ages = { 11, 12, 13, 14, 15, 16, 23,44 };
            //Console.WriteLine(ages[7]);
            int[] ages;
            ages = new int[10] { 21,22,23,24,25,26,28,27,29,30 };
            //ages[3] = 44;
            //Console.WriteLine(ages[3]);
            ////for循环遍历数组
            //for(int i = 0; i < ages.Length; i++)
            //{
            //    Console.Write(ages[i] + " ");
            //}
            ////while循环遍历数组
            //int i=0;
            //while (i<ages.Length)
            //{
            //    Console.Write(ages[i] + " ");
            //    i++;
            //}

            //foreach遍历数组
            foreach(int temp in ages)
            {
                Console.Write(temp+" ");
            }

        }
    }
}
