using CareerConsole.Core.Interfaces;

namespace CareerConsole.Console.Services;

/// <summary>
/// Implements the <see cref="IConsole"/> interface to provide system console functionality.
/// This abstraction makes testing easier by allowing console interactions to be mocked.
/// </summary>
public class SystemConsole : IConsole
{
    /// <summary>
    /// Writes a message to the console, followed by a newline character.
    /// When testing, this method can be intercepted or replaced by a mock implementation.
    /// </summary>
    /// <param name="message">The message to display.</param>
    public void WriteLine(string message)
    {
        System.Console.WriteLine(message);
    }

    /// <summary>
    /// Writes a message to the console without appending a newline character.
    /// Facilitates testing by abstracting direct console output, allowing verification of expected text output.
    /// </summary>
    /// <param name="message">The message to display.</param>
    public void Write(string message)
    {
        System.Console.Write(message);
    }
    
    /// <summary>
    /// Reads a line of text input from the console.
    /// In tests, this function can be replaced with predefined input values via a mock.
    /// </summary>
    /// <returns>The user's input as a string.</returns>
    public string ReadLine()
    {
        return System.Console.ReadLine()!;
    }
}
