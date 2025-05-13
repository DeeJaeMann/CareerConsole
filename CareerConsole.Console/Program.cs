using System;
using CareerConsole.Console.Classes;
using CareerConsole.Console.Services;

class Program
{
    static void Main(string[] args)
    {


            SystemConsole console = new();
            Menu menu = new(console);
            string userInput = string.Empty;
            
            do
            {
                menu.DisplayMenu();
                userInput = console.ReadLine();
                menu.HandleInput(userInput);
            } while (userInput.ToLower() != "q");
        
    }
}