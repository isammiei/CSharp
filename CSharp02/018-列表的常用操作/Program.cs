using System;
using System.Collections.Generic;

namespace _018_列表的常用操作
{
    class Program
    {
        static void ShowList(List<int> list)
        {
            foreach (int temp in list)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 12, 23, 34, 45, 56, 34, 67 };
            //Console.WriteLine(list.Capacity);
            //list.Add(80);
            //Console.WriteLine(list[2]);

            //list.Insert(3, 800);

            //list.Remove(34);
            //ShowList(list);

            //list.RemoveAt(2);
            //ShowList(list);

            //增删改查

            //Console.WriteLine(list.IndexOf(34));
            //Console.WriteLine(list.LastIndexOf(34));

            list.Sort();
            ShowList(list);
        }
    }
}
