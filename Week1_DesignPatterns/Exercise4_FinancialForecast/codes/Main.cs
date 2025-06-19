using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        double initialValue = 1000.0;
        double growthRate = 0.05; //5% annual growth
        int years = 5;

        //RECURSIVE APPROACH : TC-O(n), SC-O(n) (call stack)
        RecursiveForecast forecast = new RecursiveForecast(); //create an object of type RecursiveForecast
        double futureRecursiveValue = forecast.FutureValue(initialValue, growthRate, years); //call the recursive function
        Console.WriteLine($"Future value (Recursive): {futureRecursiveValue:F2}");

        //Optimized: Iterative Approach: TC-O(n), SC-O(1)
        double futureIterativeValue = IterativeForecast.FutureValueIterative(initialValue, growthRate, years);
        Console.WriteLine($"Future value (Iterative: Optimized): {futureIterativeValue:F2}");

        //Most Optimized Approach: TC-O(1), SC-O(1)
        OptimalForecast op = new OptimalForecast();
        double futureOpValue = op.FutureValue(initialValue, growthRate, years);
        Console.WriteLine($"Future Value (Most Optimal): {futureOpValue:F2}");
    }
}
