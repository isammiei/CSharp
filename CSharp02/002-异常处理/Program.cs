using System;

namespace _002_异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            try
            {
                int temp = array[4];
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("出现数组下标越界的错误");
            }
            catch (FieldAccessException e)
            {
                Console.WriteLine("出现FieldAccessException的错误");
            }
            finally
            {
                Console.WriteLine("不管是否出现异常，都会执行");
            }
            Console.WriteLine("23");
        }
    }
}
