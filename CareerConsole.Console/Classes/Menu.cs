using System;
using CareerConsole.Console.Services;
using CareerConsole.Core.Interfaces;

namespace CareerConsole.Console.Classes
{
    public class Menu
    {
        private readonly IConsole _console;

        public Menu(IConsole console)
        {
            _console = console;
        }

        public void DisplayWelcome()
        {
            _console.WriteLine("Welcome to Career Console!");
        }
        public void DisplayMenu()
        {
            _console.WriteLine("1. Option 1");
            _console.WriteLine("2. Option 2");
            _console.WriteLine("Q. Exit");
            _console.Write("Please select an option: ");
        }

        public void HandleInput(string userInput)
        {
            if (userInput.ToLower() == "q")
            {
                _console.WriteLine("Goodbye!");
            }
        }
    }
}