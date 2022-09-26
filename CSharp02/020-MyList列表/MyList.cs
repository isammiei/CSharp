using System;
using System.Collections.Generic;
using System.Text;

namespace _020_MyList列表
{
    class MyList<T>
    {
        private T[] data = new T[0];
        private int count = 0;//元素个数
        public int Capacity
        {
            get
            {
                return data.Length;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public void Add(T item)
        {
            if (data.Length == 0)
            {
                data = new T[4];
            }
            //添加元素之前，先判断数组是否已经满
            if (data.Length == count)
            {
                T[] temp = new T[count * 2];
                for(int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
            data[count] = item;
            count++;
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > count - 1)
                {
                    throw new ArgumentOutOfRangeException("索引参数超出范围了");
                }
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public void Insert(int index,T item)
        {
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("索引参数超出范围了");
            }
            for(int i = count - 1; i > index - 1; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("索引参数超出范围了");
            }
            for(int i = index + 1; i < count; i++)
            {
                data[i - 1] = data[i];
            }
            count--;
        }
        public int IndexOf(T item)
        {
            int index = -1;
            for(int i = 0; i<count; i++)
            {//ToString Equals
                if (item.Equals(data[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public int LastIndexOf(T item)
        {
            int index = -1;
            for (int i = count-1; i > 0; i--)
            {//ToString Equals
                if (item.Equals(data[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public void Sort()
        {
            Array.Sort(data, 0, count);
        }
    }
}
