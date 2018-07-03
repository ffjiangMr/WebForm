using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((Int32)Test.DEMO);
            Console.WriteLine("Hello  World!");
            Console.WriteLine(DateTime.Now.ToString("HH.mm.ss"));
            Console.Read();
        }
    }


    enum Test
    {
        TEST = 1,
        DEMO = 2,
        UNKNOW = 3,
    }
}
