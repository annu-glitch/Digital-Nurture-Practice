# Exercise 1: Singleton Pattern (C#)

## 📄 Description
This project demonstrates the **Singleton Design Pattern** using a `Logger` class in **C#**. The Singleton pattern ensures that only one instance of the logger is created and shared across the application.

---

## 📁 Files

- `Main.cs`: Contains the `Main()` method that tests the Singleton pattern.
- `Logger.cs`: Implements the Singleton `Logger` class with a static method to retrieve the single instance.

---

## ⚙️ How It Works

### Logger Class:
- Has a **private static** instance variable `uniqueLogger`.
- Constructor is **private**, so no other class can instantiate it.
- `GetInstance()` checks if an instance exists:
  - If not, it creates one.
  - Otherwise, it returns the already created instance.
- `Show(string message)` method displays log messages to the console.

### Main Class:
- Requests a logger instance twice using `Logger.GetInstance()`.
- Logs two messages.
- Verifies that both references point to the **same instance**.
