using System;
using System.Collections.Generic;
using System.Text;

namespace _005_属性
{
    class Customer
    {
        //public string name;
        public string address;
        public int age;
        public string createTime;
        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}
        //public int GetAge()
        //{
        //    return age;
        //}

        public int Age { get; set; }

        ////设置只读或只写
        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set
        //    {
        //        age = value;
        //    }
        //}

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

        //用属性创建一个public string name;成员
        public string Name { get; set; }
        public void Show()
        {
            //Console.WriteLine("名字" + name);
            Console.WriteLine("名字" + Name);
            Console.WriteLine("地址" + address);
            Console.WriteLine("年龄" + age);
            Console.WriteLine("创建时间" + createTime);
        }
    }
}
