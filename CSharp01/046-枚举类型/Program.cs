using System;

namespace _046_枚举类型
{
    class Program
    {
        enum RoleType
        {
            Mage,Archer,Assassin,Tank,Support,Warrior
        }
        static void Main(string[] args)
        {
            ////开发⼀个游戏，游戏⾓⾊有法师（Mage）、射⼿（Archer）、刺客（Assassin）、坦克 （Tank）、辅助（Support）、战⼠（Warrior），等不同类型。
            //RoleType roleType = RoleType.Tank;
            //if (roleType == RoleType.Tank)
            //{
            //    Console.WriteLine(roleType);
            //}
            Week day = Week.Tue;
            day = Week.Thu;
            int number = (int)day;
            Console.WriteLine(day);
            Console.WriteLine(number);
        }
        enum GameState
        {
            Menu,Running,Pause,Fail,Success
        }
        enum Week
        {
            Mon,Tue,Wed,Thu,Fri,Sat,Sun
        }
    }
}
