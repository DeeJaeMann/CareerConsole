using CareerConsole.Console.UI;
using CareerConsole.Console.Services;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the SystemConsole class
        SystemConsole console = new();
        
        // Create an instance of the Menu class and pass the console instance to it
        Menu menu = new(console);
        // Display the menu
        menu.DisplayMenu();
    }
}