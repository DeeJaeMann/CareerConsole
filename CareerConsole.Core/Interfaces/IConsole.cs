namespace CareerConsole.Core.Interfaces
{
    public interface IConsole
    {
         /// <summary>
         /// Interface for abstracting console operations. Allows for
         /// easier testing and mocking of console operations.
         /// </summary>
        void WriteLine(string message);
        void Write(string message);
        string ReadLine();
    }
}