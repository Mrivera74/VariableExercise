using System;

namespace shortStoryExercise
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.WriteLine("What is ytour name?");
            string username = Console.ReadLine ();

            Console.WriteLine ("What is you favorite color?");
            string favColor = Console.ReadLine ();

            Console.WriteLine ("What is your favorite Zoo animal?");
            string favZooAnimal = Console.ReadLine ();  

            Console.WriteLine ("What is your favorite resturant?");
            string favRest = Console.ReadLine ();

            Console.WriteLine ("What is your favorite flavor ice cream?");
            string favIceCream = Console.ReadLine ();

            Console.WriteLine ($"{username} went to the Zoo with some family with his favorite {favColor} T-shirt. Where they finally were able to see their favorite zoo animal, {favZooAnimal}. Then they finished the day by getting dinner at their favorite resturant {favRest} and also went to get their favorite ice cream, {favIceCream}.");
        }
    }
}

