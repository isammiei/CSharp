using System;
using System.Collections.Generic;
using System.Text;

namespace _014_索引器
{
    class Test
    {
        //public int this[int index]
        //{
        //    get
        //    {
        //        Console.WriteLine(index);
        //        return 100;
        //    }
        //    set
        //    {
        //        Console.WriteLine(index);
        //        Console.WriteLine(value);
        //    }
        //}
        private string[] name = new string[10];
        public string this[int index]
        {
            get
            {
                return name[index];
            }
            set
            {
                name[index] = value;
            }
        }
    }
}
