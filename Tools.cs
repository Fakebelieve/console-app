using System;

namespace ConsoleApp
{
    class Tools
    {
        public static void Menu()
        {
            Tools.Greetings();
            //Tools.Rectangle();
            //Tools.MilesPerGallon();
            //Tools.AliceSearch();
        }

        public static void Greetings()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
        public static void Rectangle()
        {
            Console.WriteLine("Side1?");
            string side1 = Console.ReadLine();
            Console.WriteLine("Side2?");
            string side2 = Console.ReadLine();
            double area = Double.Parse(side1) * Double.Parse(side2);
            Console.WriteLine("Area of Rectangle: " + area);
        }

        public static void MilesPerGallon()
        {
            Console.WriteLine("How many miles did you drive?");
            string miles = Console.ReadLine();
            Console.WriteLine("How many gallons of gas did you consume?");
            string gallons = Console.ReadLine();
            double mpg = Double.Parse(miles) / Double.Parse(gallons);
            Console.WriteLine("Miles per gallon: " + mpg);
        }

        public static void AliceSearch()
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            alice = alice.ToLower();
            Console.WriteLine("Please enter a string to search for:");
            string userInput = Console.ReadLine();
            bool match = alice.Contains(userInput.ToLower());
            Console.WriteLine("Contains input?: " + match);

        }
    }
}
