using System;

namespace _032_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            //3个可乐瓶可以换⼀瓶可乐，现在有364瓶可乐，问⼀共可以喝多少瓶可乐，剩下⼏个空瓶。
            //int pingNumber = 364;
            //int heNumber = 364;
            //while (pingNumber > 2)
            //{
            //    heNumber += pingNumber / 3;
            //    pingNumber = (pingNumber / 3) + (pingNumber % 3);
            //}
            //Console.WriteLine("喝的瓶数{0},剩的瓶数{1}", heNumber, pingNumber);

            ////编写⼀个应⽤程序⽤来输⼊的字符串进⾏加密，对于字⺟字符串加密规则如下：
            ////‘a’→’d’ ‘b’→’e’ ‘w’→’z’ …… ‘x’→’a’ ‘y’→’b’ ‘z’→’c’‘A’→’D’ ‘B’→’E’ ‘W’→’Z’ …… ‘X’→’A’ ‘Y’→’B’，‘Z’→’C’?对于其他字符，不进⾏加密。
            //string str = Console.ReadLine();
            //char[] strArray = str.ToCharArray();
            //for(int i = 0; i < strArray.Length; i++)
            //{
            //    if (strArray[i] >= 'a' && strArray[i] <= 'z' || strArray[i] >= 'A' && strArray[i] <= 'Z')
            //    {
            //        strArray[i] = (char)(strArray[i] + 3);
            //    }
            //    if (strArray[i] > 'Z' && strArray[i] <= 'Z' + 3)
            //    {
            //        strArray[i] = (char)(strArray[i] - 26);
            //    }
            //    if (strArray[i] > 'z' && strArray[i] <= 'z' + 3)
            //    {
            //        strArray[i] = (char)(strArray[i] - 26);
            //    }
            //}
            //foreach(char str1 in strArray)
            //{
            //    Console.Write(str1);
            //}

            //输⼊n(n<100)个数，找出其中最⼩的数，将它与最前⾯的数交换后输出这些数。
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for(int i = 0; i < strArray.Length; i++)
            {
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }
            int min = intArray[0];
            int minIndex = 0;
            for(int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < min)
                {
                    min = intArray[i];
                    minIndex = i;
                }
            }
            int temp = intArray[0];
            intArray[0] = intArray[minIndex];
            intArray[minIndex] = temp;
            foreach(int t in intArray)
            {
                Console.Write(t + " ");
            }
        }
    }
}
