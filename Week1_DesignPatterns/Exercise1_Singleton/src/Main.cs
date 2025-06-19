using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        // Try to get logger instance
        Logger logger1 = Logger.GetInstance();
        logger1.Show("This is the first log message.");

        // Try to get logger instance again
        Logger logger2 = Logger.GetInstance();
        logger2.Show("This is the second log message.");

        // Check if both references point to the same object
        if (logger1 == logger2)
        {
            Console.WriteLine("Same logger instance (Singleton works).");
        }
        else
        {
            Console.WriteLine("Different instances (Singleton failed).");
        }
    }
}

