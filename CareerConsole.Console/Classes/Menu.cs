using CareerConsole.Core.Interfaces;

namespace CareerConsole.Console.Classes;

/// <summary>
/// Represents the application's main menu, handling display and user input.
/// </summary>
public class Menu
{
    private readonly IConsole _console;
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Menu"/> class.
    /// </summary>
    /// <param name="console">An instance of the <see cref="IConsole"/></param>
    public Menu(IConsole console)
    {
        _console = console;
    }

    /// <summary>
    /// Displays the welcome message to the user.
    /// </summary>
    public void DisplayWelcome()
    {
        _console.WriteLine("Welcome to Career Console!");
    }
    
    /// <summary>
    /// Displays the main menu options to the user.
    /// </summary>
    public void DisplayMenu()
    {
        _console.WriteLine("1. Option 1");
        _console.WriteLine("2. Option 2");
        _console.WriteLine("Q. Exit");
        _console.Write("Please select an option: ");
    }

    /// <summary>
    /// Handles user input and provides appropriate responses.
    /// </summary>
    /// <param name="userInput">The input string entered by the user.</param>
    public void HandleInput(string userInput)
    {
        if (userInput.ToLower() == "q") 
        {
            _console.WriteLine("Goodbye!");
        }
        else
        {
            _console.WriteLine("Invalid Selection!");
        } 
    }
}
