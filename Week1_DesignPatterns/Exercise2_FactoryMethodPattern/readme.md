# 📄 Document Factory Method Pattern (C#)

This C# project demonstrates the **Factory Method Design Pattern** through a simple document management system. It allows opening different types of documents (Word, PDF, Excel) without the client needing to know which concrete class is used under the hood.

## 📁 Files
```
Documents.cs    // Contains: Document interface, Word/Pdf/Excel document classes, and their corresponding factories
Main.cs         // Contains the MainClass with client code
```

## 🔧 How to Run

### ▶️ In Visual Studio
1. Open or create a Console App project.
2. Add `Documents.cs` and `Main.cs` to the project.
3. Delete `Program.cs` if it exists.
4. Set `MainClass` as the startup object:
   - Right-click the project > Properties > Application > Startup object → select `MainClass`.
5. Click the green ▶️ Run button or press `F5`.

## ✅ What This Project Demonstrates
- Defines a `Document` interface.
- Implements concrete documents: `WordDocument`, `PdfDocument`, `ExcelDocument`.
- Uses factory classes: `WordFactory`, `PdfFactory`, `ExcelFactory` to handle object creation.
- The client (in `MainClass`) uses only the abstract factory/interface — not the concrete types.

## 💡 Why Use the Factory Pattern?
- ✅ Decouples object creation from usage.
- ✅ Makes the system easily extensible (add new document types without touching client logic).
- ✅ Follows the **Open/Closed Principle** (from SOLID): open for extension, closed for modification.

## 🧪 Sample Output
```
Opening a Word Document...
Opening a Pdf Document...
Opening an Excel Document...
```

## 📚 Pattern Used
**Factory Method Pattern** – a creational design pattern that provides an interface for creating objects but allows subclasses to alter the type of objects that will be created.

