# Week 2: Advanced SQL & NUnits

## Folder: Exercise1_WindowFunctions

This exercise demonstrates how to use SQL window functions like ROW_NUMBER(), RANK(), and DENSE_RANK() on a sample product dataset from an online retail store.

---

## Objective

To identify the top 3 most expensive products in each category and observe how different ranking functions handle ties in prices.

---

## Table Used

- ProductID: Unique identifier for each product
- ProductName: Name of the product
- Category: Product category (e.g., Electronics, Books)
- Price: Product price (non-null)

---

## What Each Function Did

- **ROW_NUMBER()**: Assigned a unique rank to each product within its category, even if prices were the same. No ties.
  
- **RANK()**: Assigned the same rank to products with the same price but skipped the next rank. For example: 1, 1, 3.
  
- **DENSE_RANK()**: Also gave the same rank for ties, but didn’t skip any ranks. For example: 1, 1, 2.

---

## Learning Outcome

You learn how different ranking functions behave in partitioned data, and how to use them to sort and filter results based on price within each category.
