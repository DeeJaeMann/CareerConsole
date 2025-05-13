using System;
using CareerConsole.Console.UI;
using CareerConsole.Console.Services;

class Program
{
    static void Main(string[] args)
    {

        SystemConsole console = new();
        Menu menu = new(console);
        string input = string.Empty;

        do
        {
            menu.DisplayMenu();
            input = console.ReadLine();
        } while (input.ToLower() != "q");
    }
}