public class RecursiveForecast
{
    public double FutureValue(double initialValue, double growthRate, int years)
    {
        if (years == 0) //base case
        {
            return initialValue;
        }
        return (1 + growthRate) * FutureValue(initialValue, growthRate, years - 1);
    }
}
