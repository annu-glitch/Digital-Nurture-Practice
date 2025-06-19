public class OptimalForecast{
    public double futureValue(double initialValue, double growthRate, int years){
        return initialValue * Math.pow(1+growthRate, years);    //mathematical computation
    }
}
