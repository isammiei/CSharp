using System;

namespace _014_索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array= { 34, 45, 56, 67 };
            //array[1] = 100;
            //Console.WriteLine(array[1]);
            //Test t = new Test();
            //t[9] = 200;

            //Test t = new Test();
            //t[0] = "Alice";
            //t[1] = "Alex";
            //Console.WriteLine(t[0]);
            //Console.WriteLine(t[1]);

            Week w = new Week();
            //Console.WriteLine(w.GetDay("Thu"));
            Console.WriteLine(w["Thu"]);
        }
    }
}
