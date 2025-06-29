using System;

class Program
{
    static void Main(string[] args)
    {
        // Get two references to Logger
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        // Log messages
        logger1.Log("This is the first log message.");
        logger2.Log("This is the second log message.");

        // Check if both are the same instance
        Console.WriteLine(object.ReferenceEquals(logger1, logger2)
            ? "Both loggers are the same instance (Singleton works)"
            : "Different instances (Singleton failed)");
    }
}
