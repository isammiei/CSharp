using System;

namespace _003_检测非法数据
{
    class Program
    {
        static void Main(string[] args)
        {
            //让⽤户输⼊两个数字，⽤户可能会出⼊⾮数字类型，处理该异常，如果出现该异常就 让⽤户重新输⼊，输出这两个数字的和
            Console.WriteLine("请输入两个数据，每行输入一个");
            int n1;
            int n2;
            while (true)
            {
                try
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("输入数据的格式错误，请重新输入");
                }
            }
            
            Console.WriteLine("两数之和为：{0}", n1 + n2);
        }
    }
}
