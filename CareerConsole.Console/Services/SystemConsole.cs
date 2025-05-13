using CareerConsole.Core.Interfaces;

namespace CareerConsole.Console.Services
{
    public class SystemConsole : IConsole
    {
        /* This class implements the IConsole interface and provides
         * the actual console operations. This allows for easier
         * testing and mocking of the console operations.
         */
        public void WriteLine(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Write(string message)
        {
            System.Console.Write(message);
        }
        public string ReadLine()
        {
            return System.Console.ReadLine()!;
        }

    }
}