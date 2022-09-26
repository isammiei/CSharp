using System;

namespace _038_真素数
{
    class Program
    {
        static bool IsSu(int number)
        {
            bool isSu = true;
            for (int j = 2; j < number-1; j++)//2~i-1
            {
                if (number % j == 0)
                {
                    isSu = false;
                    break;
                }
            }
            return isSu;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }
            int m = intArray[0];
            int n = intArray[1];

            for(int i = m; i < n+1; i++)
            {
                //判断是否素数
                //取得反序
                //判断是否素数

                //bool isSu = true;
                //for(int j = 2; j < i; j++)//2~i-1
                //{
                //    if (i % j == 0)
                //    {
                //        isSu = false;
                //        break;
                //    }
                //}
                bool isSu = IsSu(i);
                if (isSu)
                {
                    //取得反序 i
                    //426 (6*10+2)*10+4
                    //624
                    int temp = i;
                    int number = 0;
                    while (temp % 10 != 0)
                    {
                        number = number * 10 + temp % 10;
                        temp = temp / 10;
                    }
                    //bool isSuFan = true;
                    //for (int j = 2; j < number; j++)
                    //{
                    //    if (number % j == 0)
                    //    {
                    //        isSuFan = false;
                    //        break;
                    //    }
                    //}
                    bool isSuFan = IsSu(number);
                    if (isSuFan==true)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            
        }
    }
}
