using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Tools.Menu();
            }
        }
    }
}
