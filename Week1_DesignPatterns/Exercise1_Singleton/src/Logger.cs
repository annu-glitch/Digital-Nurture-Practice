using System;

public class Logger
{
    // static variable to hold the one and only instance
    private static Logger uniqueLogger; // only one instance will be created belonging to the class

    // private constructor to prevent external instantiation
    private Logger()
    {
        Console.WriteLine("This is a Logger instance");
    }

    // global access point for the single instance (shared by all callers)
    public static Logger GetInstance()
    {
        if (uniqueLogger == null)
        {
            uniqueLogger = new Logger(); // if no object exists, one will be created on the heap
        }
        return uniqueLogger; // returns the instance
    }

    public void Show(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}
