using System;

namespace _040_编程题
{
    class Program
    {
        //定义⼀个函数，⽤来取得⼀个数组中的最⼤值。
        //static int Max(int[] array)
        //{
        //    int max = array[0];
        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] > max)
        //        {
        //            max = array[i];
        //        }
        //    }
        //    return max;
        //}

        //定义⼀个函数，⽤来取得⼀个数字的所有因⼦，把所有因⼦返回。
        static int[] GetIn(int number)
        {
            int count = 0;
            for(int i = 1; i < number + 1; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            int[] array = new int[count];
            int index = 0;
            for(int j = 1; j < number+1; j++)
            {
                if (number % j == 0)
                {
                    array[index] = j;
                    index++;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //string[] strArray = str.Split(" ");
            //int[] intArray = new int[strArray.Length];
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    int number = Convert.ToInt32(strArray[i]);
            //    intArray[i] = number;
            //}
            //int n = Max(intArray);
            //Console.WriteLine(n);

            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = GetIn(number);
            foreach(int temp in array)
            {
                Console.Write(temp + " ");
            }
        }
    }
}
