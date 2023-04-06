using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string catName = "ChrisMorris";

            int catAge = 4;

            char initials = 'C';

            bool heshedsalot = true;

            double weight = 8;

            decimal length = 2.6m;

            Console.WriteLine($"My cats name is {catName} and he is {catAge}. His intial is just {initials}. He is {weight} lbs, {length} ft, and its {heshedsalot} he sheds alot.");
        }
    }
}

