using System;

namespace _005_属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer lisi = new Customer();
            //lisi.SetAge(23);
            //Console.WriteLine(lisi.GetAge());

            lisi.Age = 34;
            Console.WriteLine(lisi.Age);
            lisi.Name = "Alice";
            Console.WriteLine(lisi.Name);
        }
    }
}
