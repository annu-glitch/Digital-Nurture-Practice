using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventoryProject;
using RetailInventoryProject.Models;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        /*
        // Seed Categories
        var electronics = new Category { Name = "Electronics" };
        var groceries = new Category { Name = "Groceries" };
        var toy = new Category { Name = "Toys" };

        await context.Categories.AddRangeAsync(electronics, groceries);
        await context.Categories.AddAsync(toy);

        // Seed Products
        var product1 = new Product
        {
            Name = "Laptop",
            Price = 75000,
            Category = electronics,
        };

        var product2 = new Product
        {
            Name = "Rice Bag",
            Price = 1200,
            Category = groceries
        };

        var product3 = new Product
        {
            Name = "Doll House",
            Price = 2000,
            Category = toy
        };

        await context.Products.AddRangeAsync(product1, product2);
        await context.Products.AddAsync(product3);

        await context.SaveChangesAsync();
        */

        // AB 5: Retrieve Product Details

        // 1. Retrieve All Products
        var products = await context.Products.ToListAsync();
        Console.WriteLine("All Products:");
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - {p.Price}");
        }

        // 2. Find Product by ID
        var productById = await context.Products.FindAsync(12);
        Console.WriteLine($"\nFound Product with ID 12: {productById?.Name ?? "Not Found"}");

        // 3. Find First Product with Price > 50000
        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine($"\nFirst Expensive Product: {expensive?.Name ?? "None Found"}");
    }
}
