using System;

namespace _033_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            //有n(n<=100)个整数，已经按照从⼩到⼤顺序排列好，现在另外给⼀个整数x，请将该数插⼊到 序列中，并使新的序列仍然有序。
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for(int i = 0; i < strArray.Length; i++)
            {
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }
            int x = Convert.ToInt32(Console.ReadLine());
            int m = intArray.Length - 1;
            //int m = 0;
            //bool find = false;
            for(int i = 0; i < intArray.Length-1; i++)
            {
                if (x >= intArray[i] && x <= intArray[i+1])
                {
                    m = i;
                    //find = true;
                    break;
                }
            }
            if (x < intArray[0])
            {
                m = -1;
            }
            //if (find == false)
            //{
            //    m = intArray.Length - 1;
            //}
            int[] intArrayNew = new int[intArray.Length + 1];
            for(int i = 0; i < m + 1; i++)
            {
                intArrayNew[i] = intArray[i];
            }
            intArrayNew[m + 1] = x;
            for(int i = m + 1; i < intArray.Length; i++)
            {
                intArrayNew[i + 1] = intArray[i];
            }
            foreach(int temp in intArrayNew)
            {
                Console.Write(temp + " ");
            }
        }
    }
}
