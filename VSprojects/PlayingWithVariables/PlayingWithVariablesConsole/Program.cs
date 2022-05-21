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

            Console.WriteLine($"{name} {age} Correct letter {correct} This a new career {NewCareer} How long is the table {length} How tall is the table {height}");

        }
    }
}



