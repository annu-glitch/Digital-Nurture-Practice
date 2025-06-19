public class OptimalForecast
{
    public double FutureValue(double initialValue, double growthRate, int years)
    {
        //mathematical computation
        return initialValue * Math.Pow(1 + growthRate, years);
    }
}
