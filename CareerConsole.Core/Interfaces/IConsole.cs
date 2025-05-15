namespace CareerConsole.Core.Interfaces;

/// <summary>
/// Defines an abstraction for console input and output operations.
/// Allows console functionality to be replaced or mocked in tests.
/// </summary>
public interface IConsole
{
    /// <summary>
    /// Writes a message to the console followed by a newline character.
    /// </summary>
    /// <param name="message">The message to be displayed.</param>
    void WriteLine(string message);
    
    /// <summary>
    /// Writes a message to the console without appending a newline character.
    /// </summary>
    /// <param name="message">The message to be displayed</param>
    void Write(string message);
    
    /// <summary>
    /// Reads a line of text input from the console.
    /// </summary>
    /// <returns>The user's input as a string.</returns>
    string ReadLine();
}
