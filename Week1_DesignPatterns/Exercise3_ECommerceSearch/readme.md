# 🛍️ E-Commerce Search Optimization (C#)

This project demonstrates how to efficiently search through products in an e-commerce platform using **Linear Search** and **Binary Search** in **C#**. It also explains the theory of **Asymptotic Notation** to analyze performance.

---

## 1️⃣ Understand Asymptotic Notation

### ✅ What Is It?

**Asymptotic Notation** helps us evaluate how an algorithm scales with input size. Common notations:

| Notation | Meaning        | Example                  |
|----------|----------------|--------------------------|
| O(1)     | Constant time  | Accessing a list index   |
| O(n)     | Linear time    | Linear search in a list  |
| O(log n) | Logarithmic    | Binary search            |
| O(n²)    | Quadratic      | Nested loops             |

---

## 2️⃣ Case Analysis for Searching

| Search Type    | Best Case | Average Case | Worst Case | Sorted Required? |
|----------------|-----------|--------------|-------------|------------------|
| Linear Search  | O(1)      | O(n)         | O(n)        | ❌ No            |
| Binary Search  | O(1)      | O(log n)     | O(log n)    | ✅ Yes           |

---

## 3️⃣ C# Implementation Overview

- `List<Product>` is used to dynamically store products.
- The list is sorted using `Sort()` with a lambda comparator for binary search.
- Two static search methods are implemented:
  - `LinearSearch()` – iterates through each element to find a match.
  - `BinarySearch()` – performs a divide-and-conquer search, requiring the list to be sorted first.

---

## 📦 Product Structure

The `Product` class contains:
- `productId`: unique integer ID
- `productName`: name of the product
- `category`: category like electronics, fashion, etc.

It includes a constructor and a method to display product details.

---

## 🔍 SearchHelper Class Responsibilities

- `LinearSearch`: Scans the list one by one to find the matching product name (case-insensitive).
- `BinarySearch`: Efficiently finds a product by name in a sorted list using binary search logic.

---

## ✅ Output Example

```
Linear Search:
Product ID: 103, Name: Shoes, Category: Fashion

Binary Search:
Product ID: 103, Name: Shoes, Category: Fashion
```

---

## 🚀 Key Learnings

- Difference in efficiency between linear and binary search
- Importance of sorting before binary search
- Real-world application of algorithmic analysis using Big-O notation
