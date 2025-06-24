# Week 2: Advanced SQL & NUnits

## Objectives Covered

- **Understand Unit Testing vs. Functional Testing**:
  - Unit testing targets the **smallest testable unit** (e.g., method/function).
  - Unlike functional testing, it focuses on **isolated logic**, mocking dependencies.

- **Types of Testing**:
  - Unit Testing
  - Functional Testing
  - Automated Testing
  - Performance Testing

- **Benefits of Automated Testing**:
  - Fast feedback
  - Repeatable and consistent
  - Reduces manual errors

- **Loosely Coupled & Testable Design**:
  - Write code that does not depend on concrete implementations.
  - Enables mocking for unit tests.
  
---

## NUnit Testing Implementation

### Setup:

- **Project**: `.NET Framework Unit Test Project`
- **Referenced Library**: `CalcLibrary`
- **Test Class**: `CalculatorTests`
- **Framework**: NUnit 4.5.0
- **Attributes Used**:
  - `[TestFixture]` – Marks test class
  - `[SetUp]` – Runs before each test (setup)
  - `[TearDown]` – Runs after each test (cleanup)
  - `[Test]` – Marks a method as a test case
  - `[Ignore]` – Skips a test with a reason
  - `[TestCase]` – Parameterized tests
  - `Assert.That()` – Assertion syntax

---

## Tests Included

| Test Name                                | Description                               | Outcome   |
|-----------------------------------------|-------------------------------------------|-----------|
| Add_TwoPositiveNums_ReturnSum           | Adds two numbers                          | Passed |
| Add_MultipleNums_ReturnSum (x5 cases)   | Adds multiple numbers using `[TestCase]`  | Passed |
| Add_IgnoreThisTest                      | Marked with `[Ignore]`                    | Skipped |

---

## 🧾 Test Run Summary

- **Total Tests**: 7  
- **Passed**: 6  
- **Skipped**: 1  
- **Failed**: 0  
- **Total Duration**: 33 ms  
- Skipped Reason: `This test is ignored for demonstration`

---

## Setup/Teardown Output

Each test:
- Created necessary setup
- Executed test logic
- Cleaned up post-test (confirmed by output logs)
