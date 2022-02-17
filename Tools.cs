using System;

namespace ConsoleApp
{
    class Tools
    {
        public static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Greetings");
            Console.WriteLine("2) Area of Rectangle");
            Console.WriteLine("3) MPG calculator");
            Console.WriteLine("4) Alice Search");
            Console.WriteLine("5) Quit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Tools.Greetings();
                    return true;
                case "2":
                    Tools.Rectangle();
                    return true;
                case "3":
                    Tools.MilesPerGallon();
                    return true;
                case "4":
                    Tools.AliceSearch();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

        public static void Greetings()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();
        }
        public static void Rectangle()
        {
            Console.WriteLine("Side1?");
            string side1 = Console.ReadLine();
            Console.WriteLine("Side2?");
            string side2 = Console.ReadLine();
            double area = Double.Parse(side1) * Double.Parse(side2);
            Console.WriteLine("Area of Rectangle: " + area);
            Console.ReadLine();
        }

        public static void MilesPerGallon()
        {
            Console.WriteLine("How many miles did you drive?");
            string miles = Console.ReadLine();
            Console.WriteLine("How many gallons of gas did you consume?");
            string gallons = Console.ReadLine();
            double mpg = Double.Parse(miles) / Double.Parse(gallons);
            Console.WriteLine("Miles per gallon: " + mpg);
            Console.ReadLine();
        }

        public static void AliceSearch()
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            alice = alice.ToLower();
            Console.WriteLine("Please enter a string to search for:");
            string userInput = Console.ReadLine();
            bool match = alice.Contains(userInput.ToLower());
            Console.WriteLine("Contains input?: " + match);
            Console.ReadLine();

        }
    }
}
