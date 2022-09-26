using System;
using System.Collections.Generic;
using System.Text;

namespace _014_索引器
{
    class Week
    {
        private string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        public int GetDay(string day)
        {
            int i = 0;
            foreach(string temp in days)
            {
                if (temp == day)
                    return i + 1;
                i++;
            }
            return -1;
        }
        public int this[string day]
        {
            get
            {
                return GetDay(day);
            }
        }
    }
}
