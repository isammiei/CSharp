using System;
using System.Collections.Generic;
using System.Text;

namespace _019_泛型
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
        public override string ToString()
        {
            string result = age + ":" + name;
            return result;
        }
    }
}
