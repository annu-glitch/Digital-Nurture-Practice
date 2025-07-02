using System.Collections.Generic;

namespace RetailInventory.Models
{

    //creating the data model Category
    public class Category
    {
        public int Id { get; set; }   //primary key: not nullable reference type
        public string Name { get; set; } 
        public List<Product> Products { get; set; }   //navigation property: 1 to many relationship
    }

    //creating the data model Product
    public class Product
    {
        public int Id { get; set; }    //primary key
        public string Name { get; set; }     //name of the product
        public decimal Price { get; set; }     //price
        public int CategoryId { get; set; }   //foreign key
        public Category Category { get; set; }    //navigation property: many to 1 relationship
    }

}
