using System;
using System.Collections.Generic;

namespace _017_列表List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 12,23,34};
            //list.Add(90);
            //list.Add(66);
            ////Console.WriteLine(list[3]);
            //for(int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //List<int> list = new List<int>();
            //Console.WriteLine(list.Count + ":" + list.Capacity);
            //list.Add(2);
            //Console.WriteLine(list.Count + ":" + list.Capacity);
            //list.Add(2);
            //list.Add(2);
            //list.Add(2);
            //Console.WriteLine(list.Count + ":" + list.Capacity);
            //list.Add(2);
            //Console.WriteLine(list.Count + ":" + list.Capacity);

            List<int> list = new List<int>(50);
            list.Add(34);
            list.Add(45);
            foreach(int temp in list)
            {
                Console.WriteLine(temp);
            }




        }
    }
}
