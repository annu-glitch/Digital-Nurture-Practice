
# Financial Forecasting Using Recursion

## What is Recursion?

**Recursion** is a technique where a function calls itself to solve a smaller instance of the same problem. Each recursive call works on a reduced version of the input until a **base case** is reached, which stops further recursion.

### Why Use Recursion?

- Simplifies problems with repetitive or self-similar structure.
- Makes logic more elegant in cases like tree traversal, factorial, Fibonacci, or compound calculations over time.
- Useful for educational purposes to understand how problems can be broken down.

---

## Our Recursive Approach

In financial forecasting, future value can be calculated using the **compound growth formula**:

```

FV = PV × (1 + r)^n

```

We implemented this recursively as:

```

FV(n) = (1 + r) × FV(n - 1)
Base case: FV(0) = PV

```

This approach mimics how value grows year by year and is easy to understand conceptually.

---

## Drawbacks of Recursion

While recursion helps with clarity, it has performance and scalability issues:

- **Time Complexity:** O(n)
- **Space Complexity:** O(n) due to the call stack
- Can cause `StackOverflowError` for large values of `n`
- No memoization leads to recomputation of the same subproblems (in more complex recursive models)

---

## Why Iterative is Better

An **iterative approach** replaces recursion with a loop that multiplies the initial value by `(1 + r)` repeatedly for `n` years.

### Benefits:
- **Time Complexity:** O(n)
- **Space Complexity:** O(1)
- More memory-efficient and faster for larger inputs
- No risk of stack overflow

---

## Why Math.pow is Best

The most optimized solution uses the **direct mathematical formula**:

```

FV = PV × Math.pow(1 + r, n)

```

### Benefits:
- **Time Complexity:** O(1)
- **Space Complexity:** O(1)
- Fastest and most efficient
- Ideal for production-grade forecasting tools

---

## 🛠️ Optimizing the Recursive Solution

If recursion must be used, consider:

1. **Tail Recursion:** If the language supports tail call optimization.
2. **Memoization:** Store already computed results to avoid redundant calculations (in problems with overlapping subproblems).
3. **Limit Depth:** Set a recursion limit or switch to iterative after a threshold.

---

## 📌 Summary

| Approach             | Time Complexity | Space Complexity | Use Case                            |
|----------------------|------------------|-------------------|--------------------------------------|
| Recursive            | O(n)             | O(n)              | Educational or small `n` values      |
| Iterative            | O(n)             | O(1)              | Better for performance and stability |
| Direct Math (`pow`)  | O(1) ✅           | O(1) ✅            | Best for real-world forecasting      |

---

## Conclusion

Recursion is valuable for understanding the problem structure but is not suitable for large-scale, performance-critical applications. When efficiency matters, use the **iterative or direct mathematical approach** for forecasting.
```

---
