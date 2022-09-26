using System;

namespace _034_排序
{
    class Program
    {
        static void Main(string[] args)
        {
            ////编写⼀个控制台程序，要求⽤户输⼊⼀组数字⽤空格间隔，对⽤户输⼊的数字从⼩到⼤输出。
            ////(Array.Sort⽅法和冒泡排序)
            //string str = Console.ReadLine();
            //string[] strArray = str.Split(" ");
            //int[] intArray = new int[strArray.Length];
            //for(int i = 0; i < strArray.Length; i++)
            //{
            //    int number = Convert.ToInt32(strArray[i]);
            //    intArray[i] = number;
            //}
            //Array.Sort(intArray);
            //foreach(int temp in intArray)
            //{
            //    Console.Write(temp + " ");
            //}

            ////冒泡排序
            //string str = Console.ReadLine();
            //string[] strArray = str.Split(" ");
            //int[] intArray = new int[strArray.Length];
            //for(int i = 0; i < strArray.Length; i++)
            //{
            //    int number = Convert.ToInt32(strArray[i]);
            //    intArray[i] = number;
            //}
            //for(int i = 0; i < intArray.Length-1; i++)//比较intArray.Length-1轮
            //{
            //    //定义一个标志位，判断当前轮次数据是否发生交换
            //    bool isChanged = false;
            //    for (int j = 0; j < intArray.Length-1-i; j++)//开始比较
            //    {
            //        if (intArray[j] > intArray[j + 1])
            //        {
            //            //如果左边大于右边，就交换
            //            int temp = intArray[j];
            //            intArray[j] = intArray[j + 1];
            //            intArray[j + 1] = temp;
            //            isChanged = true;
            //        }
            //    }
            //    if (isChanged == false)
            //    {
            //        break;
            //    }
            //}
            //foreach(int t in intArray)
            //{
            //    Console.Write(t + " ");
            //}

            //    //输⼊⼀个字符串，判断其是否是C#的合法标识符
            //    string str = Console.ReadLine();
            //    bool isRight = true;
            //    for(int i = 0; i < str.Length; i++)
            //    {
            //        if((str[i] < '0' || str[i] > '9')&&(str[i]<'a'||str[i]>'z')&&(str[i] < 'A' || str[i] > 'Z') && (str[i] != '_'))
            //        {
            //            isRight = false;
            //            break;
            //        }
            //    }
            //    if (str[0] >= '0' && str[0] <= '9')
            //    {
            //        isRight = false;
            //    }
            //    if (isRight)
            //    {
            //        Console.WriteLine("是合法标识符");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不是合法标识符");
            //    }

            ////“回⽂串”是⼀个正读和反读都⼀样的字符串，⽐如“level”或者“noon”等等就是回⽂串。请写⼀个程序判断读⼊的字符串是否是“回⽂”。
            ////8 7
            ////0-7 1-6 2-5 3-4 i~str.length-1-i
            //string str = Console.ReadLine();
            //bool isHui = true;
            //for(int i = 0; i < str.Length / 2; i++)
            //{
            //    if (str[i] != str[str.Length - 1 - i])
            //    {
            //        isHui = false;
            //        break;
            //    }
            //}
            //if (isHui)
            //{
            //    Console.WriteLine("是回文串");
            //}
            //else
            //{
            //    Console.WriteLine("不是回文串");
            //}

            ////最近夏⽇炎热，令张三⾮常的不爽。最近张三开始研究天⽓的变化。 历经千⾟万苦，他收集了连续N（1 < N < 1000000）天的最⾼⽓温数据。 现在他想知道⽓温⼀直上升的最⻓连续天数。
            ////样例输⼊：1 3 5 2 3 5 7 8 6 9 样例输出 5
            //string str = Console.ReadLine();
            //string[] strArray = str.Split(" ");
            //int[] intArray = new int[strArray.Length];
            //for(int i = 0; i < strArray.Length; i++)
            //{
            //    int number = Convert.ToInt32(strArray[i]);
            //    intArray[i] = number;
            //}
            //int count = 1;
            //int maxDays = 1;
            //for(int i = 0; i < intArray.Length - 1; i++)
            //{
            //    if (intArray[i] < intArray[i + 1])
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        if (count > maxDays)
            //        {
            //            maxDays = count;
            //        }
            //        count = 1;
            //    }
            //}
            //if (count > maxDays)
            //{
            //    maxDays = count;
            //}
            //Console.WriteLine("气温连续升高的最长天数" + maxDays);

            //输⼊是个不相等的正整数，输出这10个正整数中的第⼆⼤的数。
            //样例输⼊3 5 7 2 9 5 3 10 3 8 样例输出 9
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }
            int max1 = 0;
            int max2 = 0;
            for(int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > max1)
                {
                    max2 = max1;
                    max1 = intArray[i];
                }
                else
                {
                    if (intArray[i] > max2)
                    {
                        max2 = intArray[i];
                    }
                }
            }
            Console.WriteLine("第一大值是{0},第二大值是{1}", max1, max2);

















        }
    }
}
