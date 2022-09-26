using System;
using System.Collections.Generic;
using System.Text;

namespace _021_Equals判断相等
{
    class Student
    {
        private int age;
        private string name;

        public Student(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public override bool Equals(object obj)
        {
            Student stu = (Student)obj;
            if (age == stu.age && name == stu.name)
            {
                return true;
            }
            return false;
        }
    }
}
