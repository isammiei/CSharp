using System;

namespace _016_switch分支语句
{
    class Program
    {
        static void Main(string[] args)
        {
            ////有⼀台⾃动售货机，⾥⾯⼀共6个商品。⽤户可以输⼊1-6选择要购买的商品。
            ////1 矿泉⽔ 2红茶 3绿茶 4雪碧 5可⼝可乐 6脉动 根据⽤户输⼊的数字，显⽰⽤户购买的商品。
            //int number = Convert.ToInt32(Console.ReadLine());
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("矿泉水");
            //        break;
            //    case 2:
            //        Console.WriteLine("红茶");
            //        break;
            //    case 3:
            //        Console.WriteLine("绿茶");
            //        break;
            //    case 4:
            //        Console.WriteLine("雪碧");
            //        break;
            //    case 5:
            //        Console.WriteLine("可口可乐");
            //        break;
            //    case 6:
            //        Console.WriteLine("脉动");
            //        break;
            //    default:
            //        Console.WriteLine("没有你要购买的商品");
            //        break;
            //}

            //输⼊今天是星期⼏，输出今天要上的课程。
            int weekNum = Convert.ToInt32(Console.ReadLine());
            switch (weekNum)
            {
                case 1:
                case 2:
                    Console.WriteLine("Arduino");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("C++");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Scratch");
                    break;
            }
        }
    }
}
