using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "哇哈哈哈";
            String b = "哇哈哈哈";
            var result = b.Contains(a);           
            var c = a.ToLowerInvariant();
            Console.WriteLine((Int32)Test.DEMO);
            Console.WriteLine("Hello  World!");
            Console.WriteLine(DateTime.Now.ToString("HH.mm.ss"));
            Enum.TryParse<Test>("", out _);
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
