using System.Collections.Generic;

namespace RetailInventoryProject.Models
{
    //Creating the data model Category
    public class Category
    {
        public int Id { get; set; }                                      //primary key
        public string Name { get; set; } = string.Empty;                 //category name
        public List<Product> Products { get; set; } = new List<Product>(); //navigation property (1 category can have many products)
    }

    //Creating the data model Product
    public class Product
    {
        public int Id { get; set; }                                      //primary key
        public string Name { get; set; } = string.Empty;                 //product name
        public decimal Price { get; set; }                               //product price
        public int CategoryId { get; set; }                              //foreign key
        public Category Category { get; set; } = new Category();         //navigation property (1 product belongs to 1 category)
    }
}
