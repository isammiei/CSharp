using System;

namespace _004_字符类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //char a = 'c';
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int a = 97;
            //char b = (char)a;//强制类型转换
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //char a = '1';
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //char a = '\n';
            //char b = '\\';
            //char c = '\"';
            //char d = '\t';
            //char e = '\'';
            //Console.WriteLine("c:\\a\\b\\c");
            //Console.WriteLine(@"c:\a\b\c");
            //Console.WriteLine(@"c:\\a\\b\\c");

            //            string str = @"www.baidu.com 
            //sdfds
            //sdf
            //sdfsdfsdf";

            //            Console.WriteLine(str);

            //string str = "123" + "456";
            //string str2 = str + "www";
            //Console.WriteLine(str2);

            //String str = Console.ReadLine();
            //Console.WriteLine(str + "-");
            //1.类型一致 2.右边的值所需要的容器大小 小于等于 左边的容器

            String str = Console.ReadLine();
            int strInt = Convert.ToInt32(str);//"12" "12" "df"
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strInt + "-" + a);



        }
    }
}
