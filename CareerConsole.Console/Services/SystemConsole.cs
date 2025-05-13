using CareerConsole.Core.Interfaces;

namespace CareerConsole.Console.Services
{
    public class SystemConsole : IConsole
    {
         /// <summary>
         /// Implements IConsole interface and provides the actual console operations.
         /// </summary>
        public void WriteLine(string message)
        {
            /// <summary>
            /// Writes a message to the console with a new line.
            /// </summary>
            /// <param name="message">The message to write.</param>
            System.Console.WriteLine(message);
        }

        public void Write(string message)
        {
            /// <summary>
            /// Writes a message to the console without a new line.
            /// </summary>
            /// <param name="message">The message to write.</param>
            System.Console.Write(message);
        }
        public string ReadLine()
        {
            /// <summary>
            /// Reads a line of input from the console.
            /// </summary>
            /// <returns>The input string.</returns>
            return System.Console.ReadLine()!;
        }

    }
}