using System;

namespace _047_结构体
{
    //学⽣信息的结构体
    //struct StudentInfo
    //{
    //    public int age;
    //    public string name;
    //    public int grade;
    //    public int id;
    //}

    //定义⼀个表⽰三维坐标的结构体
    struct Position
    {
        public double x;
        public double y;
        public double z;
        public void PrintPosition()
        {
            Console.WriteLine(x + "," + y + "," + z);
        }
    }
    struct Name
    {
        public string firstName;
        public string lastName;
        public string FullName()
        {
            return firstName + " "+ lastName+".";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //StudentInfo student1;
            //student1.age = 10;
            //student1.name = "Alice";
            //student1.grade = 2;
            //student1.id = 123;

            ////Console.WriteLine(student1.name);

            //StudentInfo[] students = new StudentInfo[10];
            //students[0].age = 30;
            //Console.WriteLine(students[0].age);

            //int[] stuAge = new int[10];
            //string[] stuName = new string[10];

            //Position p1;
            //p1.x = 23.3;
            //p1.y = 3.4;
            //p1.z = 1;
            //p1.PrintPosition();

            //Position p2;
            //p2.x = 1;
            //p2.y = 2;
            //p2.z = 3;
            //p2.PrintPosition();

            //Name name;
            //name.firstName = "Alice";
            //name.lastName = "Smith";
            //Console.WriteLine("My name is " + name.FullName());
        }
    }
}
