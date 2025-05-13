namespace CareerConsole.Core.Interfaces
{
    public interface IConsole
    {
        /* This interface is used to abstract the console operations
         * from the main program. This allows for easier testing and
         * mocking of the console operations. 
         */
        void WriteLine(string message);
        void Write(string message);
        string ReadLine();
    }
}