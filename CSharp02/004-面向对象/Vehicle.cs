using System;
using System.Collections.Generic;
using System.Text;

namespace _004_面向对象
{
    class Vehicle
    {
        public string brand;
        public int speed;
        public int maxSpeed;
        public float weight;
        public void Run()
        {
            Console.WriteLine("车辆跑起来了");
        }
        public void Stop()
        {
            Console.WriteLine("车辆停止了");
        }
    }
}
