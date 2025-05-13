using CareerConsole.Console.UI;
using CareerConsole.Console.Services;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the SystemConsole class
        var console = new SystemConsole();
        
        // Create an instance of the Menu class and pass the console instance to it
        var menu = new Menu(console);
        // Display the menu
        menu.DisplayMenu();
    }
}