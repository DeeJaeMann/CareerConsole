using System.ComponentModel;
using CareerConsole.Console.Tests.Classes;
using CareerConsole.Console.UI;

namespace CareerConsole.Console.Tests;

public class MenuTest
{
    [Fact]
    [Category("UI")]
    [Description("Test to check if the welcome message is displayed correctly.")]
    public void WelcomeMessageTest()
    {
        MockConsole mockConsole = new();
        Menu menu = new(mockConsole);

        menu.DisplayMenu();

        Assert.Contains("Welcome to the Career Console!", mockConsole.WrittenLines);
    }
}
