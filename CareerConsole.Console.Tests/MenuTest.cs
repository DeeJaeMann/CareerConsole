using System.ComponentModel;
using CareerConsole.Console.Tests.Classes;
using CareerConsole.Console.Classes;

namespace CareerConsole.Console.Tests;

/// <summary>
/// Unit tests for the <see cref="Menu"/> class.
/// Validates UI output messages based on various user interactions.
/// </summary>
public class MenuTest
{
    /// <summary>
    /// Creates a new instance of <see cref="Menu"/> with a mock console.
    /// This eliminates redundant object creation in each test method.
    /// </summary>
    /// <returns>A configured <see cref="Menu"/> instance.</returns>
    private Menu CreateTestMenu(out MockConsole mockConsole)
    {
        mockConsole = new MockConsole();
        return new Menu(mockConsole);
    }
    
    /// <summary>
    /// Tests if the welcome message is displayed correctly when <see cref="Menu.DisplayWelcome"/> is called.
    /// </summary>
    [Fact]
    [Category("UI")]
    [Description("Test to check if the welcome message is displayed correctly.")]
    public void WelcomeMessageTest()
    {

        Menu menu = CreateTestMenu(out MockConsole mockConsole);
        const string expected = "Welcome to Career Console!";

        menu.DisplayWelcome();
        List<string> actual = mockConsole.WrittenLines;

        Assert.Contains(expected, actual);
    }

    /// <summary>
    /// Tests if the menu prompt is correctly displayed when <see cref="Menu.DisplayMenu"/> is called.
    /// </summary>
    [Fact]
    [Category("UI")]
    [Description("Test to check if the menu prompt is displayed correctly.")]
    public void MenuMessageTest()
    {
        Menu menu = CreateTestMenu(out MockConsole mockConsole);
        const string expected = "Please select an option: ";
        
        menu.DisplayMenu();
        List<string> actual = mockConsole.WrittenLines;
        
        Assert.Contains(expected, actual);
    }

    /// <summary>
    /// Tests if entering 'q' or 'Q' correctly triggers the exit message.
    /// </summary>
    /// <param name="input">User input value.</param>
    [Theory]
    [InlineData("q")]
    [InlineData("Q")]
    [Description("Test to check if q or Q exits the program")]
    [Category("UI")]
    public void ExitTest(string input)
    {
        Menu menu = CreateTestMenu(out MockConsole mockConsole);
        const string expected = "Goodbye!";
        
        mockConsole.AddInput(input);
        menu.DisplayMenu();
        menu.HandleInput(input);
        List<string> actual = mockConsole.WrittenLines;

        Assert.Contains(expected, actual);
    }

    /// <summary>
    /// Tests if invalid inputs produce an error message.
    /// </summary>
    /// <param name="input">Invalid user input value.</param>
    [Theory]
    [InlineData("x")]
    [InlineData("exit")]
    [InlineData("invalid option")]
    [InlineData("12345")]
    [InlineData("\n")]
    [Description("Test to check if invalid input generates a message")]
    [Category("UI")]
    public void InvalidMenuSelectionTest(string input)
    {
        Menu menu = CreateTestMenu(out MockConsole mockConsole);
        const string expected = "Invalid Selection!";
        
        mockConsole.AddInput(input);
        menu.DisplayMenu();
        menu.HandleInput(input);
        List<string> actual = mockConsole.WrittenLines;

        Assert.Contains(expected, actual);
    }
}
