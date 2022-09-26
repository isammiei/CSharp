using System;

namespace _019_泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassA c = new ClassA(34,56);
            //Console.WriteLine(c.GetSum());

            //ClassA<int> a = new ClassA<int>(3, 56);
            //Console.WriteLine(a.GetSum());

            //ClassA<double> b = new ClassA<double>(2.5, 2.4);
            //Console.WriteLine(b.GetSum());

            //类的对象 ToString

            //Program p = new Program();
            //Console.WriteLine(p.ToString());
            //Console.WriteLine(p);

            //Program p1 = new Program();
            //Program p2 = new Program();
            //string str = p1.ToString() + p2.ToString();

            //Student s = new Student(30,"Alice");
            //Console.WriteLine(s);

            Console.WriteLine(GetSum<int>(23, 45));


        }
        public static T GetSum<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return (T)(num1 + num2);
        }
    }

    class ClassA<T>
    {
        private T a;
        private T b;

        public ClassA(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public T GetSum()
        {
            dynamic num1 = a;
            dynamic num2 = b;
            dynamic result = num1 + num2;
            return result;
        }
    }
//    class ClassA
//    {
//        private int a;
//        private int b;

//        public ClassA(int a, int b)
//        {
//            this.a = a;
//            this.b = b;
//        }
//        public int GetSum()
//        {
//            return a + b;
//        }
//    }

//    class ClassADouble
//    {
//        private double a;
//        private double b;

//        public ClassADouble(double a, double b)
//        {
//            this.a = a;
//            this.b = b;
//        }
//        public double GetSum()
//        {
//            return a + b;
//        }
//    }
//}

}
