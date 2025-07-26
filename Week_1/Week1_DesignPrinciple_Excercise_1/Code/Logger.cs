using System;

public class Logger
{
    // 1. Static variable to hold the single instance
    private static Logger instance = null;

    // 2. Lock object for thread safety (optional but recommended)
    private static readonly object padlock = new object();

    // 3. Private constructor to prevent instantiation
    private Logger()
    {
        Console.WriteLine("Logger Initialized");
    }

    // 4. Public method to provide access to the instance
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }
        }
        return instance;
    }

    // 5. A sample method to simulate logging
    public void Log(string message)
    {
        Console.WriteLine($"[Log]: {message}");
    }
}
