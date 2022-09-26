using System;

namespace _011_只读字段readonly
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base(200);
            Console.WriteLine(b.hp);
        }
    }
}
