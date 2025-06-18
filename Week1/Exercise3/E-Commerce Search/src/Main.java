import java.util.ArrayList;   //to create a resizable array to store products
import java.util.Collections;   //to sort the products alphabetically for binary search
import java.util.Comparator;

public class Main{
    public static void main(String[] args) {

        //ArrayList of product objects, resizable
        ArrayList<Product> products = new ArrayList<>();

        //Adding products to the list

        products.add(new Product(101, "Laptop", "electronics"));
        products.add(new Product(102, "Mobile Phone", "electronics"));
        products.add(new Product(103, "Shoes", "Fashion"));
        products.add(new Product(104, "Doll House", "toy"));
        products.add(new Product(105, "Dress", "Fashion"));
        products.add(new Product(106, "Notebooks", "stationary"));
        products.add(new Product(107, "Hand wash", "Hygiene"));

        //Sort the list of products for binary search
        Collections.sort(products, new Comparator<Product>(){
            public int compare(Product p1, Product p2) {  //defining rule on how to compare products
                return p1.productName.compareToIgnoreCase(p2.productName);
            }
        });
        //Target product
        String targetName = "Shoes";

        //Perform Linear Search
        System.out.println("Linear Search: ");
        Product result1 = SearchHelper.linearSearch(products, targetName);
        if(result1!=null){
            result1.display();
        } else {
            System.out.println("Product not found.");
        }

        //Perform binary search
        System.out.println("\nBinary Search: ");
        Product result2 = SearchHelper.binarySearch(products, targetName);
        if(result2!=null){
            result2.display();
        } else {
            System.out.println("Product not found");
        }

    }
}
