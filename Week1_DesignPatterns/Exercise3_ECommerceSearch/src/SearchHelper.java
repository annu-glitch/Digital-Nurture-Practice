import java.util.ArrayList;
public class SearchHelper{

    //Linear Search - O(n)
    public static Product linearSearch(ArrayList<Product> products, String targetProduct){
        for (Product p : products){     //checks one by one
            if(p.productName.equalsIgnoreCase(targetProduct)){
                return p;  //product found
            }
        }
        return null;    //product not found
    }

    //Binary Search - needs sorted array of Products - O(logn)
    public static Product binarySearch(ArrayList<Product> products, String targetProduct){
        int left = 0;
        int right = products.size() - 1;

        while (left <= right){
            int mid = (left + right)/2;
            Product midProduct = products.get(mid);
            int result = midProduct.productName.compareToIgnoreCase(targetProduct);

            if(result  == 0) {
                return midProduct;
            } else if (result < 0){
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return null; //not found
    }
}
