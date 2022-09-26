using System;

namespace _021_Equals判断相等
{
    class Program
    {
        static void Main(string[] args)
        {
            //Equals
            //ToString Equals Object
            //int a = 12;
            //int b = 12;
            //Console.WriteLine(a.Equals(b));

            //string str1 = "sammie";
            //string str2 = "sammie";
            //Console.WriteLine(str1.Equals(str2));

            Student stu1 = new Student(20, "Alice");
            Student stu2 = new Student(20, "Alice");

            Console.WriteLine(stu1.Equals(stu2));
        }
    }
}
