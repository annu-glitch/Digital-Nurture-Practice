using RetailInventoryProject;
using RetailInventoryProject.Models;              
using System.Threading.Tasks;                   //for asynchronous methods

class Program
{
   static async Task Main(string[] args)
    {
        using var context = new AppDbContext();        //create an instance of AppDbContext class to connect to database

        var electronics = new Category { Name = "Electronics" };      //creating a Category entity(row)
        var groceries = new Category { Name = "Groceries" };

        await context.Categories.AddRangeAsync(electronics, groceries);            //adding multiple entities to the context

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


        await context.Products.AddRangeAsync(product1, product2);      

        await context.SaveChangesAsync();   //save the changes to database
    }
}
