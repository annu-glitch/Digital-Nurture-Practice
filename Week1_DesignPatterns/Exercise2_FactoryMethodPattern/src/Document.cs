using System;

//Product
public interface Document
{
    void open(); //defines a common behaviour for all concrete classes
}

// WordDocument.cs
//concrete product class 1, implements product
public class WordDocument : Document
{
    public void open()
    {
        System.Console.WriteLine("Opening a Word Document...");
    }
}

// PdfDocument.cs
//concrete class 2
public class PdfDocument : Document
{
    public void open()
    {
        System.Console.WriteLine("Opening a Pdf Document...");
    }
}

// ExcelDocument.cs
//concrete class 3
public class ExcelDocument : Document
{
    public void open()
    {
        System.Console.WriteLine("Opening an Excel Document...");
    }
}

// DocumentFactory.cs
//creator
public abstract class DocumentFactory
{
    public abstract Document createDocument();
}

// WordFactory.cs
//concrete creator 1
public class WordFactory : DocumentFactory
{
    public override Document createDocument()
    {
        return new WordDocument();
    }
}

// PdfFactory.cs
//concrete creator 2
public class PdfFactory : DocumentFactory
{
    public override Document createDocument()
    {
        return new PdfDocument();
    }
}

// ExcelFactory.cs
//concrete creator 3
public class ExcelFactory : DocumentFactory
{
    public override Document createDocument()
    {
        return new ExcelDocument();
    }
}
