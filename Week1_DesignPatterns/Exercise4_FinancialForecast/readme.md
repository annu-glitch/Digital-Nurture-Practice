# 📈 Financial Forecasting Using Recursion (C#)

## 🔁 What is Recursion?

Recursion is a technique where a function **calls itself** to solve a smaller version of the same problem. Each call continues until it reaches a **base case**, which stops further recursion.

---

## 💡 Why Use Recursion?

- Simplifies problems with repetitive or self-similar structure.
- Helps conceptualize step-by-step growth (like yearly financial growth).
- Useful for education, and problems like tree traversal, factorials, Fibonacci, and compound interest.

---

## 📘 Recursive Forecasting Formula

In financial forecasting, future value is calculated as:

```
FV = PV × (1 + r)^n
```

We implemented this recursively in C# as:

```
FV(n) = (1 + r) × FV(n - 1)
Base case: FV(0) = PV
```

This reflects how value grows year by year.

---

## ⚠️ Drawbacks of Recursion in C#

| Concern            | Detail                                 |
|--------------------|-----------------------------------------|
| Time Complexity     | O(n)                                   |
| Space Complexity    | O(n) due to the function call stack     |
| Performance Issue   | Can lead to stack overflow for large `n` |
| Optimization Lacking | No memoization; recomputes values       |

---

## 🔁 Why Iterative Is Better

An **iterative approach** uses a simple loop to multiply the initial value by (1 + r) repeatedly for `n` years.

**Advantages:**

- Time Complexity: O(n)
- Space Complexity: O(1)
- No stack overflow risk
- Much faster and scalable

---

## 🚀 Why `Math.Pow()` Is the Best

The most optimized C# solution uses the direct formula:

```csharp
double result = initialValue * Math.Pow(1 + rate, years);
```

**Advantages:**

- Time Complexity: O(1)
- Space Complexity: O(1)
- Cleanest and fastest for real-world use

---

## 🛠️ Optimizing Recursion in C#

If recursion must be used:

- ✅ Use **tail recursion** (C# doesn’t optimize tail calls by default, so use with caution).
- ✅ Apply **memoization** if you encounter repeated subproblems.
- ✅ Use a **hybrid approach**, switching to iteration for larger inputs.

---

## 📌 Summary

| Approach           | Time Complexity | Space Complexity | Best For                         |
|--------------------|------------------|------------------|----------------------------------|
| Recursive          | O(n)             | O(n)             | Small inputs, educational use    |
| Iterative          | O(n)             | O(1) ✅          | General-purpose forecasting      |
| Math.Pow (Optimal) | O(1) ✅          | O(1) ✅          | Real-world, performance-focused  |

---

## ✅ Conclusion

Recursion is a great tool for learning and conceptual modeling, but in **C#** and most production environments, **iterative** or **direct math-based** solutions are preferred for **efficiency, clarity, and reliability**.
