using System;
using System.Collections.Generic;

public class SearchHelper
{
    //Linear Search - O(n)
    public static Product LinearSearch(List<Product> products, string targetProduct)
    {
        foreach (Product p in products) //checks one by one
        {
            if (p.productName.Equals(targetProduct, StringComparison.OrdinalIgnoreCase))
            {
                return p;  //product found
            }
        }
        return null;    //product not found
    }

    //Binary Search - needs sorted list of Products - O(logn)
    public static Product BinarySearch(List<Product> products, string targetProduct)
    {
        int left = 0;
        int right = products.Count - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            Product midProduct = products[mid];
            int result = string.Compare(midProduct.productName, targetProduct, StringComparison.OrdinalIgnoreCase);

            if (result == 0)
            {
                return midProduct;
            }
            else if (result < 0)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return null; //not found
    }
}
