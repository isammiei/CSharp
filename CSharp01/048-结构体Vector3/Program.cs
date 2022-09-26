using System;

namespace _048_结构体Vector3
{
    //定义⼀个Vector3的类（这个类可以⽤来表⽰坐标，可以表⽰向量），在⾥⾯定义⼀个Distance⽅法，⽤来取得⼀个向量的⻓度的
    struct Vector3
    {
        public double x;
        public double y;
        public double z;
        public double Distance()
        {
            double temp = x * x + y * y + z * z;
            return Math.Sqrt(temp);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 v1;
            v1.x = 4;
            v1.y = 5;
            v1.z = 7;
            Console.WriteLine(v1.Distance());
        }
    }
}
