using System;

    namespace PlayingWithVariablesConsole
{
    class Program
    {
        static void Main(string [] args)
        {
            //Declared Variables
            string name;
            int age;
            char correct;
            bool NewCareer;
            double length;
            decimal height;

            //Initialized Variables
            name = "Mark Rivera";
            age = 32;
            correct = 'A';
            NewCareer = true;
            length = 76.2;
            height = 24.2m;

            //Interpolate Variables
            string dogName = "Rocky";
            int dogAge = 10;
            Char typeOfDog = 'a';
            double dogLength = 24.5;
            decimal dogweight = 40.65m;
            bool purebreed = true;

            Console.WriteLine($"{name} {age} Correct letter {correct} This a new career {NewCareer} How long is the table {length} How tall is the table {height}");
            Console.WriteLine($"My dog's name is {dogName}. He is {dogAge}, his height is {dogLength} and his weight is {dogweight}. " +
                $"It is {purebreed} that my dog is a purebreed. If your would like to see the dog pictures select a, if not select b.");
                $")
        }
    }
}



