# Document Factory Method Pattern

This is a simple Java project that demonstrates the **Factory Method Design Pattern**. It simulates a document management system that can open different types of documents like Word, PDF, and Excel without the client knowing the exact class being used.

---

## Files

.
├── Document.java
├── WordDocument.java
├── PdfDocument.java
├── ExcelDocument.java
├── DocumentFactory.java
├── WordFactory.java
├── PdfFactory.java
├── ExcelFactory.java
└── Main.java

## 🔧 How to Run

javac *.java

java Main

# What This Project Does
Defines a Document interface.

Implements different document types (WordDocument, PdfDocument, ExcelDocument).

Uses factory classes (WordFactory, PdfFactory, ExcelFactory) to create documents.

Main class (Main.java) shows how the client uses the factories without knowing document class details.

# Why Factory Pattern?
Decouples object creation from usage.

Easily extendable: Add new document types without changing client code.

Follows SOLID principles: Especially Open/Closed.
