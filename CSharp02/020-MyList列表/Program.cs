using System;
using System.Collections.Generic;

namespace _020_MyList列表
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            //Console.WriteLine(list.Capacity);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(4);
            list.Add(5);
            //Console.WriteLine(list.Count);

            //List<int> l = new List<int>();
            //int temp = l[-1];

            list.Insert(2, 100);
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            list.RemoveAt(3);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(list.IndexOf(100));
            Console.WriteLine();

            Console.WriteLine(list.IndexOf(4));
            Console.WriteLine(list.LastIndexOf(4));
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
