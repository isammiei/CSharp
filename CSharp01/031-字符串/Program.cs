using System;

namespace _031_字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Sammie";
            //for(int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            ////倒序遍历⼀个字符串中的每⼀个字符。
            //string name = "Sammie";
            //for(int i = name.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //string name = " Sammie Sum ";
            //string str1 = name.ToLower();
            //Console.WriteLine(str1);

            //string str2 = name.ToUpper();
            //Console.WriteLine(str2);

            //string str3 = name.Trim();
            //Console.WriteLine(name+"-"+str3);

            //string str4 = name.TrimStart();
            //Console.WriteLine(name + "-" + str4+"|");

            //string str5 = name.TrimEnd();
            //Console.WriteLine(name + "-" + str5+"|");

            string color = "red,blue,yellow";
            string[] strArray = color.Split(",");
            foreach(string str in strArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}
