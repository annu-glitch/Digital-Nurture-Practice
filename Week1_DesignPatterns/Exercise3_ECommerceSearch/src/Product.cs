public class Product
{
    public int productId;
    public string productName;
    public string category;

    //Constructor
    public Product(int productId, string productName, string category)
    {
        this.productId = productId;
        this.productName = productName;
        this.category = category;
    }

    public void Display()
    {
        System.Console.WriteLine("Product ID: " + productId +
                ", Name: " + productName +
                ", Category: " + category);
    }
}
