using CareerConsole.Console.UI;
using CareerConsole.Console.Services;

class Program
{
    static void Main(string[] args)
    {

        SystemConsole console = new();
        Menu menu = new(console);

        menu.DisplayMenu();
    }
}