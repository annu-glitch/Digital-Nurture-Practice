public class Main{
    public static void main(String[] args) {
        double initialValue = 1000.0;
        double growthRate = 0.05;   //5% annual growth
        int years = 5;

        //RECURSIVE APPROACH : TC-O(n), SC-O(n) (call stack)
        RecursiveForecast forecast = new RecursiveForecast();   //create an object of type RecursiveForecast
        double futureRecursiveValue = forecast.futureValue(initialValue, growthRate, years);   //call the recursive function
        //System.out.println("The future value is: " + futureValue);
        System.out.printf("Future value (Recursive): %.2f%n", futureRecursiveValue);


        //Optimized: Iterative Approach: TC-O(n), SC-O(1)
        double futureIterativeValue = IterativeForecast.futureValueIterative(initialValue, growthRate, years);
        System.out.printf("Future value (Iterative: Optimized): %.2f%n", futureIterativeValue);
      

        //Most Optimized Approach: TC-O(1), SC-O(1)
        OptimalForecast op = new OptimalForecast();
        double futureOpValue = op.futureValue(initialValue, growthRate, years);
        System.out.printf("Future Value (Most Optimal): %.2f%n", futureOpValue);
    }
}
