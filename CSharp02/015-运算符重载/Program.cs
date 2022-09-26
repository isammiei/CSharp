using System;

namespace _015_运算符重载
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(20,"Alice",12);
            Student s2 = new Student(20,"Alice",12);
            //Student s3 = s1;
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 != s2);
            //Console.WriteLine(s1 == s3);
        }
    }
}
