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