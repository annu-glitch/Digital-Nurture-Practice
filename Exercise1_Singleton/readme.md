# Exercise 1: Singleton Pattern

## Description
This project demonstrates the Singleton Design Pattern using a `Logger` class. The pattern ensures that only one instance of the logger is created and shared across the application.

---

## Files

- `Main.java`: Contains the main method that tests the Singleton pattern.
- `Logger.java`: Implements the Singleton Logger class with a static method to get the single instance.

---

## How It Works

- The `Logger` class has:
  - A private static instance variable (`uniqueLogger`)
  - A private constructor to prevent direct instantiation
  - A `getInstance()` method that returns the same logger instance each time
  - A `show()` method to print log messages

- The `Main` class:
  - Gets two references to the logger using `getInstance()`
  - Logs messages with both references
  - Verifies both references point to the same instance

---

## Expected Output

This is a Logger instance
Log: This is the first log message.
Log: This is the second log message.
Same logger instance (Singleton works).

