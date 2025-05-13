using System.ComponentModel;
using CareerConsole.Console.Tests.Classes;
using CareerConsole.Console.Classes;
using Xunit.Abstractions;

namespace CareerConsole.Console.Tests;

public class MenuTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public MenuTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    [Category("UI")]
    [Description("Test to check if the welcome message is displayed correctly.")]
    public void WelcomeMessageTest()
    {
        MockConsole mockConsole = new();
        Menu menu = new(mockConsole);
        const string expected = "Welcome to the Career Console!";

        menu.DisplayMenu();
        List<string> actual = mockConsole.WrittenLines;

        Assert.Contains(expected, actual);
    }

    [Theory]
    [InlineData("q")]
    [InlineData("Q")]
    [Description("Test to check if q or Q exits the program")]
    [Category("UI")]
    public void ExitTest(string input)
    {
        MockConsole mockConsole = new();
        Menu menu = new(mockConsole);
        const string expected = "Goodbye!";
        
        mockConsole.AddInput(input);
        menu.DisplayMenu();
        menu.HandleInput(input);
        List<string> actual = mockConsole.WrittenLines;

        Assert.Contains(expected, actual);
    }
}
