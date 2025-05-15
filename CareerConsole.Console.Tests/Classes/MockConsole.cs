using CareerConsole.Core.Interfaces;

namespace CareerConsole.Console.Tests.Classes;

/// <summary>
/// A mock implementation of <see cref="IConsole"/> for unit testing.
/// Allows tests to verify console output and control simulated user input.
/// </summary>
public class MockConsole : IConsole
{
    /// <summary>
    /// Queue used to store predefined user input values for testing.
    /// </summary>
    private readonly Queue<string> _inputQueue = new();
    
    /// <summary>
    /// List of messages written to the console, allowing assertions in tests.
    /// </summary>
    public List<string> WrittenLines { get; } = new();

    /// <summary>
    /// Simulates writing a message to the console, storing it for verification
    /// </summary>
    /// <param name="message">The message to be written</param>
    public void WriteLine(string message) => WrittenLines.Add(message);
    
    /// <summary>
    /// Simulates writing a message to the console without a newline, storing it for verification.
    /// </summary>
    /// <param name="message">The message to be written</param>
    public void Write(string message) => WrittenLines.Add(message);
    
    /// <summary>
    /// Simulates reading user input, returning predefined values from the queue.
    /// If no input is available, returns an empty string.
    /// </summary>
    /// <returns>The next input value or an empty string.</returns>
    public string ReadLine() => _inputQueue.Count > 0 ? _inputQueue.Dequeue() : string.Empty;
    
    /// <summary>
    /// Adds a predefined input value to the queue for simulated user interaction in tests.
    /// </summary>
    /// <param name="input">The input value to enqueue.</param>
    public void AddInput(string input) => _inputQueue.Enqueue(input);
}
