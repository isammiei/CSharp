using System;

namespace _004_面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //利用类创建对象，c1就是对象名
            //Customer c1 = new Customer();
            //Customer c2;//声明对象
            //c2 = new Customer();//实例化一个对象
            //c1.name = "Sammie";
            //c1.address = "中国";
            //c1.age = 20;
            //c1.createTime = "2022";
            //c1.Show();

            //Vehicle car1 = new Vehicle();
            //car1.Run();
            //car1.Stop();

            //Vector3 v1 = new Vector3();
            //v1.SetX(3.2f);
            //v1.SetY(4.5f);
            //v1.SetZ(6.7f);
            //Console.WriteLine(v1.GetX());
            //Console.WriteLine(v1.Length());

            //Customer lisi = new Customer();
            Customer alice = new Customer("Alice", "UK", 20, "2022");
            alice.Show();




        }
    }
}
