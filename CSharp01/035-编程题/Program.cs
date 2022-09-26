using System;

namespace _035_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            ////描述给定⼀个只包含⼩写字⺟的字符串，请你找出第⼀个仅出现⼀次的字符。如果没有，输出no
            //string str = Console.ReadLine();
            //char temp = ' ';
            //for(int i = 0; i < str.Length; i++)
            //{
            //    int count = 0;
            //    for(int j = 0; j < str.Length; j++)
            //    {
            //        if (str[j] == str[i])
            //        {
            //            count++;
            //            if (count == 2)
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    if (count == 1)
            //    {
            //        temp = str[i];
            //        break;
            //    }
            //}
            //if(temp==' ')
            //{
            //    Console.WriteLine("no");
            //}
            //else
            //{
            //    Console.WriteLine(temp);
            //}

            ////法2：
            //string str = Console.ReadLine();
            //int[] countArray = new int[26];//计数，保存每个字符出现的次数
            //for(int i = 0; i < str.Length; i++)
            //{
            //    countArray[str[i] - 'a'] = countArray[str[i] - 'a'] + 1;
            //}
            //bool isFinded = false;
            //char c = ' ';
            //for(int i = 0; i < str.Length; i++)
            //{
            //    if (countArray[str[i] - 'a'] == 1)
            //    {
            //        isFinded = true;
            //        c = str[i];
            //    }
            //}
            //if (isFinded == false)
            //{
            //    Console.WriteLine("no");
            //}
            //else
            //{
            //    Console.WriteLine(c);
            //}

            ////把⼀个字符串中所有出现的⼤写字⺟都替换成⼩写字⺟，同时把⼩写字⺟替换成⼤写字⺟。
            //string str = Console.ReadLine();
            //int cha = 'A' - 'a';
            //for(int i = 0; i < str.Length; i++)
            //{
            //    if(str[i] >= 'a' && str[i] <= 'z')
            //    {
            //        char c = (char)(str[i] + cha);
            //        Console.Write(c);
            //    }else if(str[i] >= 'A' && str[i] <= 'Z')
            //    {
            //        char c = (char)(str[i] - cha);
            //        Console.Write(c);
            //    }
            //    else
            //    {
            //        Console.Write(str[i]);
            //    }
            //}

            //在⼀个数组中查找⼀个给定的值，输出第⼀次出现的位置（从1开始） 输⼊第⼀⾏是数组中的元素 第⼆⾏是要查找的数 输出输出第⼀次出现的位置
            //输⼊3 8 23 45 2 5 23 输出3
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }
            int num = Convert.ToInt32(Console.ReadLine());
            int location = -1;
            for(int i = 0; i < intArray.Length; i++)
            {
                if (num==intArray[i])
                {
                    location = i + 1;
                    break;
                }
            }
            Console.WriteLine(location);











        }
    }
}
