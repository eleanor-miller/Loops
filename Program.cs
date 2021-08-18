using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 9;

            while (counter < 10)
            {
                Console.WriteLine("Doing something");

                //counter = counter + 1;
                counter++;
            }

            // INITIALIZER compacted while loop
            for (var counterOne = 0; counterOne < 5; counterOne++)
            {
                Console.WriteLine("What is up?");
            }

            var names = new List<string>() { "Mark", "Paula", "Sandy" };

            // names [0]
            // names [1]
            // names [2]

            names.Add("Eleanor");

            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();

            names.Add(name);

            while (name != "quit")

            {
                Console.WriteLine($" -- {names.Count} People --");
                // Print out the whole list of names
                //for (var index = 0; index < names.Count; index++)
                //{
                //   var currentName = names[index];
                //   Console.WriteLine(currentName);
                //}

                // For each takes away index
                foreach (var currentName in names)
                {
                  Console.WriteLine(currentName);
                }
                Console.WriteLine();

                Console.Write("What is your name? ");
                name = Console.ReadLine();
                names.Add(name);
            }

            // For Each
        }
    }
}
