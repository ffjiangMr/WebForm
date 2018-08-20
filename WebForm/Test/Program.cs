using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {

        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        // Uses method-based query syntax.
        public static void GroupByEx1()
        {
            // Create a list of pets.
            List<Pet> pets =
                new List<Pet>{ new Pet { Name="Barley", Age=8 },
                       new Pet { Name="Boots", Age=4 },
                       new Pet { Name="Whiskers", Age=1 },
                       new Pet { Name="Daisy", Age=4 } };

            // Group the pets using Age as the key value 
            // and selecting only the pet's Name for each value.
            IEnumerable<IGrouping<int, string>> query =
                pets.GroupBy(pet => pet.Age, pet => pet.Name);

            // Iterate over each IGrouping in the collection.
            foreach (IGrouping<int, string> petGroup in query)
            {
                // Print the key value of the IGrouping.
                Console.WriteLine(petGroup.Key);
                // Iterate over each value in the 
                // IGrouping and print the value.
                foreach (string name in petGroup)
                    Console.WriteLine("  {0}", name);
            }
        }

        static void Main(string[] args)
        {
            GroupByEx1();
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
