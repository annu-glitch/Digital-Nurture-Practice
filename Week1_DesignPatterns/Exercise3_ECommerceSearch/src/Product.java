public class Product{
    int productId;
    String productName;
    String category;

    //Constructor
    public Product(int productId, String productName, String category){
        this.productId = productId;
        this.productName = productName;
        this.category = category;
    }

    public void display() {
        System.out.println("Product ID: " + productId +
                ", Name: " + productName +
                ", Category: " + category);
    }
}
