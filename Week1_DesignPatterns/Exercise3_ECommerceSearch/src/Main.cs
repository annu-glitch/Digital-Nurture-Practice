using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main(string[] args)
    {
        //List of product objects, resizable
        List<Product> products = new List<Product>();

        //Adding products to the list
        products.Add(new Product(101, "Laptop", "electronics"));
        products.Add(new Product(102, "Mobile Phone", "electronics"));
        products.Add(new Product(103, "Shoes", "Fashion"));
        products.Add(new Product(104, "Doll House", "toy"));
        products.Add(new Product(105, "Dress", "Fashion"));
        products.Add(new Product(106, "Notebooks", "stationary"));
        products.Add(new Product(107, "Hand wash", "Hygiene"));

        //Sort the list of products for binary search
        products.Sort((p1, p2) => p1.productName.CompareTo(p2.productName)); //comparator logic

        //Target product
        string targetName = "Shoes";

        //Perform Linear Search
        Console.WriteLine("Linear Search: ");
        Product result1 = SearchHelper.LinearSearch(products, targetName);
        if (result1 != null)
        {
            result1.Display();
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        //Perform binary search
        Console.WriteLine("\nBinary Search: ");
        Product result2 = SearchHelper.BinarySearch(products, targetName);
        if (result2 != null)
        {
            result2.Display();
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }
}
