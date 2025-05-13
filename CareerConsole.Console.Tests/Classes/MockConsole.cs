using CareerConsole.Core.Interfaces;

namespace CareerConsole.Console.Tests.Classes
{
    public class MockConsole : IConsole
    {
        private readonly Queue<string> _inputQueue = new();
        public List<string> WrittenLines { get; } = new();

        public void WriteLine(string message) => WrittenLines.Add(message);
        public void Write(string message) => WrittenLines.Add(message);
        public string ReadLine() => _inputQueue.Count > 0 ? _inputQueue.Dequeue() : string.Empty;

        public void AddInput(string input) => _inputQueue.Enqueue(input);
    }
}