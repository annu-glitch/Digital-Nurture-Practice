# 🛍️ E-Commerce Search Optimization

This project demonstrates how to efficiently search through products in an e-commerce platform using **Linear Search** and **Binary Search**, and explains the theory of **Asymptotic Notation** to analyze performance.

---

## 1️⃣ Understand Asymptotic Notation

### ✅ What Is It?

Asymptotic Notation helps us **measure how an algorithm performs** as the input size grows. We use:

- `O(...)` → Worst-case time
- `Ω(...)` → Best-case time
- `Θ(...)` → Average-case time

### 🧠 Big O Notation

| Notation | Meaning        | Example              |
|----------|----------------|----------------------|
| O(1)     | Constant time   | Accessing an array index |
| O(n)     | Linear time     | Linear search in array  |
| O(log n) | Logarithmic     | Binary search           |
| O(n²)    | Quadratic       | Nested loops            |

---

## 2️⃣ Case Analysis for Searching

| Search Type   | Best Case | Average Case | Worst Case | Sorted Required? |
|---------------|-----------|--------------|------------|------------------|
| Linear Search | O(1)      | O(n)         | O(n)       | ❌ No             |
| Binary Search | O(1)      | O(log n)     | O(log n)   | ✅ Yes            |

---

## 3️⃣ Java Code Overview

We use:
- `ArrayList<Product>` to store products
- `Collections.sort()` with `Comparator`
- Two search methods: Linear and Binary

---

## 📦 Product Class

```java
public class Product {
    int productId;
    String productName;
    String category;

    public Product(int id, String name, String category) {
        this.productId = id;
        this.productName = name;
        this.category = category;
    }
}
